using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDT
{
    public partial class DDTControl: Form
    {
        private void clearFileList()
        {
            int selected = fileListBox.SelectedItems.Count;

            if (selected == 0)
            {
                return;
            }
            else
            {
                for (int x = fileListBox.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int i = fileListBox.SelectedIndices[x];
                    fileListBox.Items.RemoveAt(i);
                }
            }
        }

        private void removeSelectedFilesFromList()
        {
            for (int x = fileListBox.Items.Count - 1; x >= 0; x--)
            {
                fileListBox.Items.RemoveAt(x);
            }
        }

        private void AddFilesToList()
        {
            foreach (string s in openFileDialog.FileNames)
            {
                fileListBox.Items.Add(s);
            }
        }

        private void ChoosingAlgorithmModes()
        {
            if (radioAlgorithmSTD.Checked)
            {
                checkBoxDisintegrate.Enabled = false;
                checkBoxDisintegrate.CheckState = CheckState.Checked;
                checkBoxDisrupt.Enabled = false;
                checkBoxDisrupt.CheckState = CheckState.Checked;
                checkBoxTerminate.Enabled = false;
                checkBoxTerminate.CheckState = CheckState.Checked;
            }
            else
            {
                checkBoxDisintegrate.Enabled = true;
                checkBoxDisrupt.Enabled = true;
                checkBoxTerminate.Enabled = true;
            }
        }

        private void OpeningFileDialog()
        {
            openFileDialog.ShowDialog();
        }
    }
}
