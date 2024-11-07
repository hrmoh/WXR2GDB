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
            SuspendLayout();
            // 
            // txtInputFile
            // 
            txtInputFile.Location = new Point(37, 44);
            txtInputFile.Name = "txtInputFile";
            txtInputFile.Size = new Size(1004, 36);
            txtInputFile.TabIndex = 0;
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
            btnConvert.Location = new Point(37, 102);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(1078, 46);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 198);
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
    }
}
