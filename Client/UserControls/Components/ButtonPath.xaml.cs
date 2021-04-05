using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows;
using System.Windows.Controls;

namespace Client.UserControls.Components
{
    /// <summary>
    /// Логика взаимодействия для ButtonPath.xaml
    /// </summary>
    public partial class ButtonPath : UserControl
    {
        private bool forChooseFile = false;
        private string path = "";

        public ButtonPath(bool forChooseFile)
        {
            InitializeComponent();
            this.forChooseFile = forChooseFile;
            if (forChooseFile)
                Button.Content = "Выбрать директорию";
            else
                Button.Content = "Выбрать файл";
        }

        private string getPath()
        {
            return this.path;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string title = this.forChooseFile ? "Выбрать файл" : "Выбрать директорию";

            var dlg = new CommonOpenFileDialog();
            dlg.Title = title;
            dlg.IsFolderPicker = !this.forChooseFile;

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
                this.path =  dlg.FileName;
        }
    }
}
