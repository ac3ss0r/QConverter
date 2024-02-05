using MetroFramework.Forms;

namespace QConverter {
    public partial class FileActionForm : MetroForm {

        private string targetFilePath;

        public FileActionForm(string targetFile) {
            this.targetFilePath = targetFile;
            InitializeComponent();
        }

        private void metroRadioButton3_CheckedChanged(object sender, System.EventArgs e) {

        }

        private void FileActionForm_Load(object sender, System.EventArgs e) {

        }
    }
}
