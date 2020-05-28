namespace XTools__purnadika
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabTextLinesRemover = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbWith = new System.Windows.Forms.TextBox();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDuplicate = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbExtraTabsSpaces = new System.Windows.Forms.CheckBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.listSelectedFiles = new System.Windows.Forms.ListBox();
            this.cbRemoveEmptyLine = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAutoDoIt = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKeyTextAuto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDoIt = new System.Windows.Forms.Button();
            this.rbKeep = new System.Windows.Forms.RadioButton();
            this.rbRemove = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKeyText = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbTargetText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabTextLinesRemover.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTextLinesRemover
            // 
            this.tabTextLinesRemover.Controls.Add(this.tabPage2);
            this.tabTextLinesRemover.Controls.Add(this.tabPage1);
            this.tabTextLinesRemover.Location = new System.Drawing.Point(12, 12);
            this.tabTextLinesRemover.Name = "tabTextLinesRemover";
            this.tabTextLinesRemover.SelectedIndex = 0;
            this.tabTextLinesRemover.Size = new System.Drawing.Size(1451, 622);
            this.tabTextLinesRemover.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.cbDuplicate);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cbExtraTabsSpaces);
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listSelectedFiles);
            this.tabPage2.Controls.Add(this.cbRemoveEmptyLine);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.btnAutoDoIt);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbKeyTextAuto);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnSelectFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1443, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text Files Lines Remover";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(132, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Replacer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbWith);
            this.groupBox1.Controls.Add(this.tbTarget);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(227, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 82);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacer";
            // 
            // tbWith
            // 
            this.tbWith.Location = new System.Drawing.Point(122, 45);
            this.tbWith.Name = "tbWith";
            this.tbWith.Size = new System.Drawing.Size(254, 20);
            this.tbWith.TabIndex = 26;
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(122, 15);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(254, 20);
            this.tbTarget.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Replae With";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Target Text";
            // 
            // cbDuplicate
            // 
            this.cbDuplicate.AutoSize = true;
            this.cbDuplicate.Location = new System.Drawing.Point(426, 149);
            this.cbDuplicate.Name = "cbDuplicate";
            this.cbDuplicate.Size = new System.Drawing.Size(142, 17);
            this.cbDuplicate.TabIndex = 22;
            this.cbDuplicate.Text = "Remove Duplicate Items";
            this.cbDuplicate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Post process";
            // 
            // cbExtraTabsSpaces
            // 
            this.cbExtraTabsSpaces.AutoSize = true;
            this.cbExtraTabsSpaces.Location = new System.Drawing.Point(259, 150);
            this.cbExtraTabsSpaces.Name = "cbExtraTabsSpaces";
            this.cbExtraTabsSpaces.Size = new System.Drawing.Size(161, 17);
            this.cbExtraTabsSpaces.TabIndex = 20;
            this.cbExtraTabsSpaces.Text = "Remove Extra Tabs/Spaces";
            this.cbExtraTabsSpaces.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(623, 570);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(814, 23);
            this.progressBar2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listSelectedFiles
            // 
            this.listSelectedFiles.FormattingEnabled = true;
            this.listSelectedFiles.Location = new System.Drawing.Point(623, 6);
            this.listSelectedFiles.Name = "listSelectedFiles";
            this.listSelectedFiles.Size = new System.Drawing.Size(814, 563);
            this.listSelectedFiles.TabIndex = 17;
            // 
            // cbRemoveEmptyLine
            // 
            this.cbRemoveEmptyLine.AutoSize = true;
            this.cbRemoveEmptyLine.Location = new System.Drawing.Point(132, 150);
            this.cbRemoveEmptyLine.Name = "cbRemoveEmptyLine";
            this.cbRemoveEmptyLine.Size = new System.Drawing.Size(121, 17);
            this.cbRemoveEmptyLine.TabIndex = 16;
            this.cbRemoveEmptyLine.Text = "Remove Empty Line";
            this.cbRemoveEmptyLine.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 264);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(607, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // btnAutoDoIt
            // 
            this.btnAutoDoIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoDoIt.Location = new System.Drawing.Point(392, 21);
            this.btnAutoDoIt.Name = "btnAutoDoIt";
            this.btnAutoDoIt.Size = new System.Drawing.Size(225, 112);
            this.btnAutoDoIt.TabIndex = 14;
            this.btnAutoDoIt.Text = "✓ Just Do It!";
            this.btnAutoDoIt.UseVisualStyleBackColor = true;
            this.btnAutoDoIt.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(252, 116);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Keep Containing";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(132, 116);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Remove Containing";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Key Text";
            // 
            // tbKeyTextAuto
            // 
            this.tbKeyTextAuto.Location = new System.Drawing.Point(132, 76);
            this.tbKeyTextAuto.Name = "tbKeyTextAuto";
            this.tbKeyTextAuto.Size = new System.Drawing.Size(254, 20);
            this.tbKeyTextAuto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select File(s)";
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(132, 21);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(93, 33);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "Select File(s)";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDoIt);
            this.tabPage1.Controls.Add(this.rbKeep);
            this.tabPage1.Controls.Add(this.rbRemove);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbKeyText);
            this.tabPage1.Controls.Add(this.tbResult);
            this.tabPage1.Controls.Add(this.tbTargetText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1443, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual Lines Remover";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDoIt
            // 
            this.btnDoIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoIt.Location = new System.Drawing.Point(880, 249);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new System.Drawing.Size(557, 62);
            this.btnDoIt.TabIndex = 9;
            this.btnDoIt.Text = "Just Do It!";
            this.btnDoIt.UseVisualStyleBackColor = true;
            // 
            // rbKeep
            // 
            this.rbKeep.AutoSize = true;
            this.rbKeep.Location = new System.Drawing.Point(277, 286);
            this.rbKeep.Name = "rbKeep";
            this.rbKeep.Size = new System.Drawing.Size(103, 17);
            this.rbKeep.TabIndex = 8;
            this.rbKeep.TabStop = true;
            this.rbKeep.Text = "Keep Containing";
            this.rbKeep.UseVisualStyleBackColor = true;
            // 
            // rbRemove
            // 
            this.rbRemove.AutoSize = true;
            this.rbRemove.Location = new System.Drawing.Point(157, 286);
            this.rbRemove.Name = "rbRemove";
            this.rbRemove.Size = new System.Drawing.Size(118, 17);
            this.rbRemove.TabIndex = 7;
            this.rbRemove.TabStop = true;
            this.rbRemove.Text = "Remove Containing";
            this.rbRemove.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Target Text";
            // 
            // tbKeyText
            // 
            this.tbKeyText.Location = new System.Drawing.Point(157, 246);
            this.tbKeyText.Name = "tbKeyText";
            this.tbKeyText.Size = new System.Drawing.Size(100, 20);
            this.tbKeyText.TabIndex = 2;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(157, 317);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbResult.Size = new System.Drawing.Size(1280, 273);
            this.tbResult.TabIndex = 1;
            // 
            // tbTargetText
            // 
            this.tbTargetText.Location = new System.Drawing.Point(157, 3);
            this.tbTargetText.Multiline = true;
            this.tbTargetText.Name = "tbTargetText";
            this.tbTargetText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbTargetText.Size = new System.Drawing.Size(1280, 237);
            this.tbTargetText.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.listAllFiles);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 646);
            this.Controls.Add(this.tabTextLinesRemover);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sapopoe Dev Tools @purnadika";
            this.tabTextLinesRemover.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTextLinesRemover;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDoIt;
        private System.Windows.Forms.RadioButton rbKeep;
        private System.Windows.Forms.RadioButton rbRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKeyText;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbTargetText;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnAutoDoIt;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKeyTextAuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cbRemoveEmptyLine;
        private System.Windows.Forms.ListBox listSelectedFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbExtraTabsSpaces;
        private System.Windows.Forms.CheckBox cbDuplicate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbWith;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

