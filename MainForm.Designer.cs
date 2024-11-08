namespace WXR2GDB
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInputFile = new TextBox();
            btnSelectFile = new Button();
            btnConvert = new Button();
            label1 = new Label();
            label2 = new Label();
            btnSelectOutputFile = new Button();
            txtOutputFile = new TextBox();
            label3 = new Label();
            txtCatTitle = new TextBox();
            label4 = new Label();
            btnSelectTextOutput = new Button();
            txtTextOutput = new TextBox();
            btnExport = new Button();
            SuspendLayout();
            // 
            // txtInputFile
            // 
            txtInputFile.Location = new Point(103, 44);
            txtInputFile.Name = "txtInputFile";
            txtInputFile.Size = new Size(938, 36);
            txtInputFile.TabIndex = 0;
            txtInputFile.Tag = "";
            txtInputFile.Text = "C:\\g\\WordPress.2024-11-07.xml";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(1047, 38);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(68, 46);
            btnSelectFile.TabIndex = 1;
            btnSelectFile.Text = "...";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(37, 206);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(1078, 46);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 29);
            label1.TabIndex = 3;
            label1.Text = "WXR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 99);
            label2.Name = "label2";
            label2.Size = new Size(67, 29);
            label2.TabIndex = 6;
            label2.Text = "GDB:";
            // 
            // btnSelectOutputFile
            // 
            btnSelectOutputFile.Location = new Point(1047, 90);
            btnSelectOutputFile.Name = "btnSelectOutputFile";
            btnSelectOutputFile.Size = new Size(68, 46);
            btnSelectOutputFile.TabIndex = 5;
            btnSelectOutputFile.Text = "...";
            btnSelectOutputFile.UseVisualStyleBackColor = true;
            btnSelectOutputFile.Click += btnSelectOutputFile_Click;
            // 
            // txtOutputFile
            // 
            txtOutputFile.Location = new Point(103, 96);
            txtOutputFile.Name = "txtOutputFile";
            txtOutputFile.Size = new Size(938, 36);
            txtOutputFile.TabIndex = 4;
            txtOutputFile.Text = "C:\\g\\naser.gdb";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 155);
            label3.Name = "label3";
            label3.Size = new Size(164, 29);
            label3.TabIndex = 7;
            label3.Text = "New Cat Title:";
            // 
            // txtCatTitle
            // 
            txtCatTitle.Location = new Point(192, 152);
            txtCatTitle.Name = "txtCatTitle";
            txtCatTitle.RightToLeft = RightToLeft.Yes;
            txtCatTitle.Size = new Size(923, 36);
            txtCatTitle.TabIndex = 8;
            txtCatTitle.Text = "جدید";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 271);
            label4.Name = "label4";
            label4.Size = new Size(63, 29);
            label4.TabIndex = 11;
            label4.Text = "TXT:";
            // 
            // btnSelectTextOutput
            // 
            btnSelectTextOutput.Location = new Point(1056, 262);
            btnSelectTextOutput.Name = "btnSelectTextOutput";
            btnSelectTextOutput.Size = new Size(68, 46);
            btnSelectTextOutput.TabIndex = 10;
            btnSelectTextOutput.Text = "...";
            btnSelectTextOutput.UseVisualStyleBackColor = true;
            btnSelectTextOutput.Click += btnSelectTextOutput_Click;
            // 
            // txtOutput
            // 
            txtTextOutput.Location = new Point(112, 268);
            txtTextOutput.Name = "txtOutput";
            txtTextOutput.Size = new Size(938, 36);
            txtTextOutput.TabIndex = 9;
            txtTextOutput.Text = "C:\\g\\naser.txt";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(37, 324);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(1078, 46);
            btnExport.TabIndex = 12;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 419);
            Controls.Add(btnExport);
            Controls.Add(label4);
            Controls.Add(btnSelectTextOutput);
            Controls.Add(txtTextOutput);
            Controls.Add(txtCatTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSelectOutputFile);
            Controls.Add(txtOutputFile);
            Controls.Add(label1);
            Controls.Add(btnConvert);
            Controls.Add(btnSelectFile);
            Controls.Add(txtInputFile);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "WordPress eXtended RSS 2 Descktop Ganjoor DB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputFile;
        private Button btnSelectFile;
        private Button btnConvert;
        private Label label1;
        private Label label2;
        private Button btnSelectOutputFile;
        private TextBox txtOutputFile;
        private Label label3;
        private TextBox txtCatTitle;
        private Label label4;
        private Button btnSelectTextOutput;
        private TextBox txtTextOutput;
        private Button btnExport;
    }
}
