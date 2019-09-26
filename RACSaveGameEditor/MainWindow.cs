using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace RACSaveGameEditor
{
    class MainWindow : Window
    {
        #pragma warning disable CS0649
        [UI] private ImageMenuItem fileOpenEncryptedPS3;
        [UI] private ImageMenuItem fileOpenDecryptedPS3;
        [UI] private ImageMenuItem fileOpenPSVita;
        [UI] private ImageMenuItem fileOpenPS2PSU;
        [UI] private ImageMenuItem fileSaveButton;
        [UI] private ImageMenuItem fileSaveAsButton;
        [UI] private ImageMenuItem closeTabButton;
        [UI] private ImageMenuItem quitButton;
        [UI] private ImageMenuItem aboutButton;
        
        [UI] private Notebook notebook;
        private Builder builder;

        #pragma warning restore CS0649

        public MainWindow() : this(new Builder("MainWindow.glade"))
        {
        }

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
        {
            this.builder = builder;
            builder.Autoconnect(this);
            DeleteEvent += Window_DeleteEvent;
            fileOpenEncryptedPS3.Activated += (sender, args) =>
            {
                string filename = OpenFileOpenDialog(FileChooserAction.SelectFolder);
                if (filename.Length > 0) {
                    LoadSaveGame(new SaveGameContainer.EncryptedPS3(filename));
                }
            };
            fileOpenDecryptedPS3.Activated += (sender, args) =>
            {
                string filename = OpenFileOpenDialog(FileChooserAction.SelectFolder);
                if (filename.Length > 0) {
                    LoadSaveGame(new SaveGameContainer.DecryptedPS3(filename));
                }
            };
            //fileOpenPS2PSU.Activated += FileOpenButton_Clicked;
            fileSaveButton.Activated += FileSaveButton_Clicked;
            closeTabButton.Activated += CloseTabButton_Clicked;
            quitButton.Activated += Window_DeleteEvent;

            aboutButton.Activated += AboutButton_Clicked;
        }

        private void AboutButton_Clicked(object sender, EventArgs e)
        {
            AboutDialog about = (AboutDialog) builder.GetObject("AboutDialog");
            about.Run();
            about.Hide();
        }

        private void CloseTabButton_Clicked(object sender, EventArgs e)
        {
            if (notebook.CurrentPage >= 0) {
                notebook.RemovePage(notebook.CurrentPage);
            }
        }

        private void FileSaveButton_Clicked(object sender, EventArgs e)
        {
            if (notebook.CurrentPage >= 0) {
                SaveGamePage page = (SaveGamePage) notebook.GetNthPage(notebook.CurrentPage);
                page.ExportData();
            }
        }

        private string OpenFileOpenDialog(FileChooserAction action)
        {
            var dialog = new FileChooserDialog(
                "Please select a savegame.", 
                this, action,
                "Cancel",
                ResponseType.Cancel,
                "Open",
                ResponseType.Ok
            );

            var result = "";
            
            if (dialog.Run() == (int) ResponseType.Ok)
            {
                result = dialog.Filename;
            }

            dialog.Hide();

            return result;
        }

        private void Window_DeleteEvent(object sender, EventArgs eventArgs)
        {
            Application.Quit();
        }

        private void LoadSaveGame(SaveGameContainer container)
        {
            notebook.AppendPage(new SaveGamePage(container), new Label(System.IO.Path.GetFileName(container.path)));
            notebook.CurrentPage = notebook.NPages - 1;
        }

    }
}