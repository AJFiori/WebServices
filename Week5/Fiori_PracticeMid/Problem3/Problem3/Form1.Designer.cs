namespace Problem3
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
            this.rtMeat = new System.Windows.Forms.RichTextBox();
            this.rtCal = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtMeat
            // 
            this.rtMeat.Location = new System.Drawing.Point(12, 153);
            this.rtMeat.Name = "rtMeat";
            this.rtMeat.Size = new System.Drawing.Size(324, 96);
            this.rtMeat.TabIndex = 5;
            this.rtMeat.Text = "";
            // 
            // rtCal
            // 
            this.rtCal.Location = new System.Drawing.Point(12, 46);
            this.rtCal.Name = "rtCal";
            this.rtCal.Size = new System.Drawing.Size(324, 96);
            this.rtCal.TabIndex = 4;
            this.rtCal.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(12, 16);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(324, 23);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Get Info";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 261);
            this.Controls.Add(this.rtMeat);
            this.Controls.Add(this.rtCal);
            this.Controls.Add(this.btnGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtMeat;
        private System.Windows.Forms.RichTextBox rtCal;
        private System.Windows.Forms.Button btnGet;
    }
}

