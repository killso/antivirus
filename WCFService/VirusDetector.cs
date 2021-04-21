using System;
using System.Collections.Generic;
using System.IO;

namespace WCFService
{
    public class VirusDetector
    {
        public VirusDetector() { }
        public static bool detect(string path)
        {
            bool isVirus = false;

            FileStream file;
            try { file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite); }
            catch (IOException) { return isVirus; }
            if (file.Length == 0) return false;

            bool should_scanning = false;
            switch ((char)file.ReadByte())
            {
                case 'M':
                    if ((char)file.ReadByte() == 'Z')
                        should_scanning = true;
                    break;
                case '.':
                    if ((char)file.ReadByte() == 'E' &&
                        (char)file.ReadByte() == 'L' &&
                        (char)file.ReadByte() == 'F')
                        should_scanning = true;
                    break;
                default:
                    break;
            }

            if (should_scanning)
                isVirus = find_virus(file);

            file.Close();
            return isVirus;
        }

        private static bool find_virus(Stream stream)
        {
            int offset = 0;
            bool isVirus = false;
            byte[] data = get_code(stream, ref offset);
            if (data == null) return isVirus;

            for (int i = 0; i < data.Length - 4 && !isVirus; i++)
            {
                string sign = bytes_to_string(data, i, 4);
                List<Virus> viruses = DatabaseConnector.get_viruses(sign, offset + i);
                foreach (Virus virus in viruses)
                {
                    if (signature_is_match(virus, data, i))
                    {
                        isVirus = true;
                        return isVirus;
                    }
                }
            }

            return isVirus;
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
    }
}
