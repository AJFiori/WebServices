namespace Problem1
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
            this.btnGetPlayers = new System.Windows.Forms.Button();
            this.rtPlayers = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGetPlayers
            // 
            this.btnGetPlayers.Location = new System.Drawing.Point(12, 12);
            this.btnGetPlayers.Name = "btnGetPlayers";
            this.btnGetPlayers.Size = new System.Drawing.Size(260, 23);
            this.btnGetPlayers.TabIndex = 0;
            this.btnGetPlayers.Text = "Get FootBall Players";
            this.btnGetPlayers.UseVisualStyleBackColor = true;
            this.btnGetPlayers.Click += new System.EventHandler(this.btnGetPlayers_Click);
            // 
            // rtPlayers
            // 
            this.rtPlayers.Location = new System.Drawing.Point(13, 69);
            this.rtPlayers.Name = "rtPlayers";
            this.rtPlayers.Size = new System.Drawing.Size(259, 150);
            this.rtPlayers.TabIndex = 1;
            this.rtPlayers.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rtPlayers);
            this.Controls.Add(this.btnGetPlayers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetPlayers;
        private System.Windows.Forms.RichTextBox rtPlayers;
    }
}

