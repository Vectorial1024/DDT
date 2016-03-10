namespace DDT
{
    partial class DDTControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClearFileList = new System.Windows.Forms.Button();
            this.buttonRemoveFiles = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.checkBoxTerminate = new System.Windows.Forms.CheckBox();
            this.checkBoxDisrupt = new System.Windows.Forms.CheckBox();
            this.checkBoxDisintegrate = new System.Windows.Forms.CheckBox();
            this.radioAlgorithmCustom = new System.Windows.Forms.RadioButton();
            this.radioAlgorithmSTD = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonClearFileList);
            this.groupBox1.Controls.Add(this.buttonRemoveFiles);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.fileListBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "File/Directory List:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Specify what files/directories you would like to shred with the DDT Shredder";
            // 
            // buttonClearFileList
            // 
            this.buttonClearFileList.Location = new System.Drawing.Point(553, 204);
            this.buttonClearFileList.Name = "buttonClearFileList";
            this.buttonClearFileList.Size = new System.Drawing.Size(103, 23);
            this.buttonClearFileList.TabIndex = 3;
            this.buttonClearFileList.Text = "Clear List";
            this.buttonClearFileList.UseVisualStyleBackColor = true;
            this.buttonClearFileList.Click += new System.EventHandler(this.buttonClearFileListClicked);
            // 
            // buttonRemoveFiles
            // 
            this.buttonRemoveFiles.Location = new System.Drawing.Point(9, 204);
            this.buttonRemoveFiles.Name = "buttonRemoveFiles";
            this.buttonRemoveFiles.Size = new System.Drawing.Size(104, 23);
            this.buttonRemoveFiles.TabIndex = 2;
            this.buttonRemoveFiles.Text = "Remove Files";
            this.buttonRemoveFiles.UseVisualStyleBackColor = true;
            this.buttonRemoveFiles.Click += new System.EventHandler(this.buttonRemoveFilesClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add files...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAddFileCLicked);
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(6, 48);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.fileListBox.Size = new System.Drawing.Size(650, 121);
            this.fileListBox.TabIndex = 0;
            // 
            // checkBoxTerminate
            // 
            this.checkBoxTerminate.AutoSize = true;
            this.checkBoxTerminate.Location = new System.Drawing.Point(72, 73);
            this.checkBoxTerminate.Name = "checkBoxTerminate";
            this.checkBoxTerminate.Size = new System.Drawing.Size(164, 17);
            this.checkBoxTerminate.TabIndex = 5;
            this.checkBoxTerminate.Text = "Execute Terminater Algorithm";
            this.checkBoxTerminate.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisrupt
            // 
            this.checkBoxDisrupt.AutoSize = true;
            this.checkBoxDisrupt.Location = new System.Drawing.Point(72, 50);
            this.checkBoxDisrupt.Name = "checkBoxDisrupt";
            this.checkBoxDisrupt.Size = new System.Drawing.Size(156, 17);
            this.checkBoxDisrupt.TabIndex = 4;
            this.checkBoxDisrupt.Text = "Execute Disrupter Algorithm";
            this.checkBoxDisrupt.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisintegrate
            // 
            this.checkBoxDisintegrate.AutoSize = true;
            this.checkBoxDisintegrate.Location = new System.Drawing.Point(72, 27);
            this.checkBoxDisintegrate.Name = "checkBoxDisintegrate";
            this.checkBoxDisintegrate.Size = new System.Drawing.Size(173, 17);
            this.checkBoxDisintegrate.TabIndex = 3;
            this.checkBoxDisintegrate.Text = "Execute Disintegrater Algorithm";
            this.checkBoxDisintegrate.UseVisualStyleBackColor = true;
            // 
            // radioAlgorithmCustom
            // 
            this.radioAlgorithmCustom.AutoSize = true;
            this.radioAlgorithmCustom.Location = new System.Drawing.Point(3, 26);
            this.radioAlgorithmCustom.Name = "radioAlgorithmCustom";
            this.radioAlgorithmCustom.Size = new System.Drawing.Size(63, 17);
            this.radioAlgorithmCustom.TabIndex = 2;
            this.radioAlgorithmCustom.Text = "Custom:";
            this.radioAlgorithmCustom.UseVisualStyleBackColor = true;
            // 
            // radioAlgorithmSTD
            // 
            this.radioAlgorithmSTD.AutoSize = true;
            this.radioAlgorithmSTD.Location = new System.Drawing.Point(3, 3);
            this.radioAlgorithmSTD.Name = "radioAlgorithmSTD";
            this.radioAlgorithmSTD.Size = new System.Drawing.Size(171, 17);
            this.radioAlgorithmSTD.TabIndex = 1;
            this.radioAlgorithmSTD.Text = "Standard DDT Shred Algorithm";
            this.radioAlgorithmSTD.UseVisualStyleBackColor = true;
            this.radioAlgorithmSTD.CheckedChanged += new System.EventHandler(this.radioAlgorithmSTD_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Specify how the program should be run.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 138);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program Arguments";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioAlgorithmSTD);
            this.panel1.Controls.Add(this.checkBoxTerminate);
            this.panel1.Controls.Add(this.radioAlgorithmCustom);
            this.panel1.Controls.Add(this.checkBoxDisrupt);
            this.panel1.Controls.Add(this.checkBoxDisintegrate);
            this.panel1.Location = new System.Drawing.Point(9, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 100);
            this.panel1.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Help";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(556, 390);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Execute";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(223, 390);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Cancel and Close";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(113, 390);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(104, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Clear All Fields";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Files|*.*";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Select Files";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialogReadingFile);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 418);
            this.panel2.TabIndex = 10;
            // 
            // DDTControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 443);
            this.Controls.Add(this.panel2);
            this.Name = "DDTControl";
            this.Text = "Disintegrate, Disrupt, Terminate (DDT)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemoveFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClearFileList;
        private System.Windows.Forms.CheckBox checkBoxTerminate;
        private System.Windows.Forms.CheckBox checkBoxDisrupt;
        private System.Windows.Forms.CheckBox checkBoxDisintegrate;
        private System.Windows.Forms.RadioButton radioAlgorithmCustom;
        private System.Windows.Forms.RadioButton radioAlgorithmSTD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel2;
    }
}

