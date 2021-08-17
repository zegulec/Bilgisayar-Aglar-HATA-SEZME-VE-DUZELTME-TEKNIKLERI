namespace veri_odev
{
    partial class acilis
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
            this.CRC = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CHECKSUM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CRC
            // 
            this.CRC.Location = new System.Drawing.Point(274, 96);
            this.CRC.Name = "CRC";
            this.CRC.Size = new System.Drawing.Size(153, 76);
            this.CRC.TabIndex = 1;
            this.CRC.Text = "CRC";
            this.CRC.UseVisualStyleBackColor = true;
            this.CRC.Click += new System.EventHandler(this.CRC_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "LRC-VRC";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 76);
            this.button2.TabIndex = 3;
            this.button2.Text = "HAMMING";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CHECKSUM
            // 
            this.CHECKSUM.Location = new System.Drawing.Point(51, 96);
            this.CHECKSUM.Name = "CHECKSUM";
            this.CHECKSUM.Size = new System.Drawing.Size(153, 76);
            this.CHECKSUM.TabIndex = 4;
            this.CHECKSUM.Text = "CHECKSUM";
            this.CHECKSUM.UseVisualStyleBackColor = true;
            this.CHECKSUM.Click += new System.EventHandler(this.CHECKSUM_Click);
            // 
            // acilis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 359);
            this.Controls.Add(this.CRC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CHECKSUM);
            this.Name = "acilis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CRC;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CHECKSUM;
    }
}

