namespace rc4
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
            this.selFile = new System.Windows.Forms.Button();
            this.encKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.genKey = new System.Windows.Forms.Button();
            this.saveKey = new System.Windows.Forms.Button();
            this.importKey = new System.Windows.Forms.Button();
            this.faultyKeyText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encSpeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numForKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selFile
            // 
            this.selFile.Location = new System.Drawing.Point(13, 13);
            this.selFile.Name = "selFile";
            this.selFile.Size = new System.Drawing.Size(75, 23);
            this.selFile.TabIndex = 0;
            this.selFile.Text = "Select file...";
            this.selFile.UseVisualStyleBackColor = true;
            this.selFile.Click += new System.EventHandler(this.selFile_Click);
            // 
            // encKey
            // 
            this.encKey.Location = new System.Drawing.Point(44, 49);
            this.encKey.Name = "encKey";
            this.encKey.Size = new System.Drawing.Size(287, 20);
            this.encKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key:";
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(12, 260);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 3;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(256, 260);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 4;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // genKey
            // 
            this.genKey.Location = new System.Drawing.Point(19, 121);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(103, 23);
            this.genKey.TabIndex = 5;
            this.genKey.Text = "Generate Key";
            this.genKey.UseVisualStyleBackColor = true;
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            // 
            // saveKey
            // 
            this.saveKey.Location = new System.Drawing.Point(256, 121);
            this.saveKey.Name = "saveKey";
            this.saveKey.Size = new System.Drawing.Size(75, 23);
            this.saveKey.TabIndex = 6;
            this.saveKey.Text = "Save Key";
            this.saveKey.UseVisualStyleBackColor = true;
            this.saveKey.Click += new System.EventHandler(this.saveKey_Click);
            // 
            // importKey
            // 
            this.importKey.Location = new System.Drawing.Point(142, 121);
            this.importKey.Name = "importKey";
            this.importKey.Size = new System.Drawing.Size(75, 23);
            this.importKey.TabIndex = 7;
            this.importKey.Text = "Import key";
            this.importKey.UseVisualStyleBackColor = true;
            this.importKey.Click += new System.EventHandler(this.importKey_Click);
            // 
            // faultyKeyText
            // 
            this.faultyKeyText.AutoSize = true;
            this.faultyKeyText.Location = new System.Drawing.Point(16, 147);
            this.faultyKeyText.Name = "faultyKeyText";
            this.faultyKeyText.Size = new System.Drawing.Size(35, 13);
            this.faultyKeyText.TabIndex = 8;
            this.faultyKeyText.Text = "label2";
            this.faultyKeyText.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Encryption speed:";
            // 
            // encSpeed
            // 
            this.encSpeed.AutoSize = true;
            this.encSpeed.Location = new System.Drawing.Point(114, 191);
            this.encSpeed.Name = "encSpeed";
            this.encSpeed.Size = new System.Drawing.Size(35, 13);
            this.encSpeed.TabIndex = 10;
            this.encSpeed.Text = "label3";
            this.encSpeed.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Decryption speed:";
            // 
            // decSpeed
            // 
            this.decSpeed.AutoSize = true;
            this.decSpeed.Location = new System.Drawing.Point(114, 217);
            this.decSpeed.Name = "decSpeed";
            this.decSpeed.Size = new System.Drawing.Size(35, 13);
            this.decSpeed.TabIndex = 12;
            this.decSpeed.Text = "label4";
            this.decSpeed.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of bytes in key generation:";
            // 
            // numForKey
            // 
            this.numForKey.Location = new System.Drawing.Point(193, 83);
            this.numForKey.Name = "numForKey";
            this.numForKey.Size = new System.Drawing.Size(36, 20);
            this.numForKey.TabIndex = 14;
            this.numForKey.Text = "16";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 295);
            this.Controls.Add(this.numForKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.faultyKeyText);
            this.Controls.Add(this.importKey);
            this.Controls.Add(this.saveKey);
            this.Controls.Add(this.genKey);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encKey);
            this.Controls.Add(this.selFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selFile;
        private System.Windows.Forms.TextBox encKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button genKey;
        private System.Windows.Forms.Button saveKey;
        private System.Windows.Forms.Button importKey;
        private System.Windows.Forms.Label faultyKeyText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label encSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label decSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numForKey;
    }
}

