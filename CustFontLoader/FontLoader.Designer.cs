namespace CustFontLoader
{
    partial class FontLoader
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
            this.cbFontList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl30ptSample = new System.Windows.Forms.Label();
            this.lbl22ptSample = new System.Windows.Forms.Label();
            this.lbl18ptSample = new System.Windows.Forms.Label();
            this.lbl15ptSample = new System.Windows.Forms.Label();
            this.lbl12ptSample = new System.Windows.Forms.Label();
            this.lbl10ptSample = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFontList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFolderPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbFontList
            // 
            this.cbFontList.FormattingEnabled = true;
            this.cbFontList.Location = new System.Drawing.Point(82, 40);
            this.cbFontList.Name = "cbFontList";
            this.cbFontList.Size = new System.Drawing.Size(284, 21);
            this.cbFontList.TabIndex = 3;
            this.cbFontList.SelectedIndexChanged += new System.EventHandler(this.cbFontList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Font : ";
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(79, 20);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(69, 13);
            this.lblFolderPath.TabIndex = 1;
            this.lblFolderPath.Text = "Not Selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fonts Folder : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl30ptSample);
            this.groupBox2.Controls.Add(this.lbl22ptSample);
            this.groupBox2.Controls.Add(this.lbl18ptSample);
            this.groupBox2.Controls.Add(this.lbl15ptSample);
            this.groupBox2.Controls.Add(this.lbl12ptSample);
            this.groupBox2.Controls.Add(this.lbl10ptSample);
            this.groupBox2.Location = new System.Drawing.Point(13, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // lbl30ptSample
            // 
            this.lbl30ptSample.AutoSize = true;
            this.lbl30ptSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl30ptSample.Location = new System.Drawing.Point(3, 214);
            this.lbl30ptSample.Name = "lbl30ptSample";
            this.lbl30ptSample.Size = new System.Drawing.Size(360, 46);
            this.lbl30ptSample.TabIndex = 9;
            this.lbl30ptSample.Text = "abcdefABCDEF-30";
            // 
            // lbl22ptSample
            // 
            this.lbl22ptSample.AutoSize = true;
            this.lbl22ptSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl22ptSample.Location = new System.Drawing.Point(3, 167);
            this.lbl22ptSample.Name = "lbl22ptSample";
            this.lbl22ptSample.Size = new System.Drawing.Size(353, 36);
            this.lbl22ptSample.TabIndex = 8;
            this.lbl22ptSample.Text = "abcdefgABCDEFGHIJ-22";
            // 
            // lbl18ptSample
            // 
            this.lbl18ptSample.AutoSize = true;
            this.lbl18ptSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl18ptSample.Location = new System.Drawing.Point(4, 127);
            this.lbl18ptSample.Name = "lbl18ptSample";
            this.lbl18ptSample.Size = new System.Drawing.Size(362, 29);
            this.lbl18ptSample.TabIndex = 7;
            this.lbl18ptSample.Text = "abcdefghijklmABCDEFGHIJK-18";
            // 
            // lbl15ptSample
            // 
            this.lbl15ptSample.AutoSize = true;
            this.lbl15ptSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl15ptSample.Location = new System.Drawing.Point(4, 90);
            this.lbl15ptSample.Name = "lbl15ptSample";
            this.lbl15ptSample.Size = new System.Drawing.Size(346, 25);
            this.lbl15ptSample.TabIndex = 6;
            this.lbl15ptSample.Text = "abcdefghijklmnopqrstuvwxyzABCD-15";
            // 
            // lbl12ptSample
            // 
            this.lbl12ptSample.AutoSize = true;
            this.lbl12ptSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12ptSample.Location = new System.Drawing.Point(7, 59);
            this.lbl12ptSample.Name = "lbl12ptSample";
            this.lbl12ptSample.Size = new System.Drawing.Size(346, 20);
            this.lbl12ptSample.TabIndex = 5;
            this.lbl12ptSample.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJK-12";
            // 
            // lbl10ptSample
            // 
            this.lbl10ptSample.AutoSize = true;
            this.lbl10ptSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10ptSample.Location = new System.Drawing.Point(7, 32);
            this.lbl10ptSample.Name = "lbl10ptSample";
            this.lbl10ptSample.Size = new System.Drawing.Size(301, 17);
            this.lbl10ptSample.TabIndex = 4;
            this.lbl10ptSample.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJK-10";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(95, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(223, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FontLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 405);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FontLoader";
            this.Text = "Font Loader";
            this.Load += new System.EventHandler(this.FontLoader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFontList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl30ptSample;
        private System.Windows.Forms.Label lbl22ptSample;
        private System.Windows.Forms.Label lbl18ptSample;
        private System.Windows.Forms.Label lbl15ptSample;
        private System.Windows.Forms.Label lbl12ptSample;
        private System.Windows.Forms.Label lbl10ptSample;
        private System.Windows.Forms.Button btnClose;
    }
}

