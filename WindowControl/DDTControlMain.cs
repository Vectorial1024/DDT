using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DDT
{
    public partial class DDTControl : Form
    {
        public DDTControl()
        {
            InitializeComponent();
        }
        
        private void radioAlgorithmSTD_CheckedChanged(object sender, EventArgs e)
        {
            ChoosingAlgorithmModes();
        }

        private void buttonRemoveFilesClicked(object sender, EventArgs e)
        {
            removeSelectedFilesFromList();
        }

        private void buttonClearFileListClicked(object sender, EventArgs e)
        {
            clearFileList();
        }

        private void FileDialogReadingFile(object sender, CancelEventArgs e)
        {
            AddFilesToList();
        }

        private void buttonAddFileCLicked(object sender, EventArgs e)
        {
            OpeningFileDialog();
        }
    }
}
