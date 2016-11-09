namespace InClass3
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetWU = new System.Windows.Forms.Button();
            this.rtResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Get Weather Information";
            // 
            // btnGetWU
            // 
            this.btnGetWU.Location = new System.Drawing.Point(59, 52);
            this.btnGetWU.Name = "btnGetWU";
            this.btnGetWU.Size = new System.Drawing.Size(154, 23);
            this.btnGetWU.TabIndex = 4;
            this.btnGetWU.Text = "WUnderground For Boston";
            this.btnGetWU.UseVisualStyleBackColor = true;
            this.btnGetWU.Click += new System.EventHandler(this.btnGetWU_Click);
            // 
            // rtResults
            // 
            this.rtResults.Location = new System.Drawing.Point(16, 100);
            this.rtResults.Name = "rtResults";
            this.rtResults.Size = new System.Drawing.Size(256, 157);
            this.rtResults.TabIndex = 5;
            this.rtResults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 269);
            this.Controls.Add(this.rtResults);
            this.Controls.Add(this.btnGetWU);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetWU;
        private System.Windows.Forms.RichTextBox rtResults;
    }
}

