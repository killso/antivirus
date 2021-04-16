using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для VirusDetector
/// </summary>
public class VirusDetector
{
    public static bool detect(string path)
    {
        bool isVirus = false;

        FileStream file;
        try { file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite); }
        catch (IOException) { return isVirus; }

        bool should_scanning = is_should_scanning(file);
        if (should_scanning)
            isVirus = find_virus(file);

        file.Close();
        return isVirus;
    }

    private static bool is_should_scanning(Stream file)
    {
        if (file.Length == 0) return false;

        bool result = false;
        switch ((char)file.ReadByte())
        {
            case 'M':
                if ((char)file.ReadByte() == 'Z')
                    result = true;
                break;
            case '.':
                if ((char)file.ReadByte() == 'E' &&
                    (char)file.ReadByte() == 'L' &&
                    (char)file.ReadByte() == 'F')
                    result = true;
                break;
            default:
                break;
        }

        return result;
    }

    private static bool find_virus(Stream stream)
    {
        int offset = 0;
        bool isDanger = false;
        byte[] data = get_code(stream, ref offset);
        if (data == null) return isDanger;

        DatabaseConnector db = new DatabaseConnector();
        for (int i = 0; i < data.Length - 4 && !isDanger; i++)
        {
            string sign = bytes_to_string(data, i, 4);
            List<Virus> viruses = db.get_viruses(sign, offset + i);
            foreach (Virus virus in viruses)
            {
                if (signature_is_match(virus, data, i))
                {
                    isDanger = true;
                    return isDanger;
                }
            }
        }

        return isDanger;
    }

    private static byte[] get_code(Stream stream, ref int offset)
    {
        bool textIsFound = false;
        while (!textIsFound)
        {
            switch ((char)stream.ReadByte())
            {
                case '.':
                    if ((char)stream.ReadByte() == 't' &&
                        (char)stream.ReadByte() == 'e' &&
                        (char)stream.ReadByte() == 'x' &&
                        (char)stream.ReadByte() == 't')
                    {
                        textIsFound = true;
                        break;
                    }
                    continue;
                default:
                    break;
            }
            if (stream.Position == stream.Length - 1)
                return null;
        }

        stream.Position += 10;

        byte[] array = new byte[4];

        stream.Read(array, 0, 4);
        Array.Reverse(array, 0, array.Length);
        int rawDataSize = BitConverter.ToInt32(array, 0);

        stream.Read(array, 0, 4);
        Array.Reverse(array, 0, array.Length);
        int rawDataPosition = BitConverter.ToInt32(array, 0);

        array = new byte[rawDataSize];
        offset = rawDataPosition;
        stream.Position = rawDataPosition;
        stream.Read(array, 0, rawDataSize - 1);
        stream.Close();
        return array;
    }

    private static string bytes_to_string(byte[] array, int index, int length)
    {
        return BitConverter.ToString(array, index, length).Replace("-", "");
    }

    private static bool signature_is_match(Virus virus, byte[] data, int offset)
    {
        string signature = bytes_to_string(data, offset, virus.signature.Length / 2);
        bool signatureInFrame = (offset + virus.signature.Length) < virus.offsetEnd;
        if (signature.Equals(virus.signature) && signatureInFrame)
            return true;
        return false;
    }
}