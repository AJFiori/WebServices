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
            this.btnGetData = new System.Windows.Forms.Button();
            this.rtGenderPrice = new System.Windows.Forms.RichTextBox();
            this.rtItemNumber = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(88, 31);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Read Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // rtGenderPrice
            // 
            this.rtGenderPrice.Location = new System.Drawing.Point(36, 60);
            this.rtGenderPrice.Name = "rtGenderPrice";
            this.rtGenderPrice.Size = new System.Drawing.Size(196, 44);
            this.rtGenderPrice.TabIndex = 1;
            this.rtGenderPrice.Text = "";
            // 
            // rtItemNumber
            // 
            this.rtItemNumber.Location = new System.Drawing.Point(36, 134);
            this.rtItemNumber.Name = "rtItemNumber";
            this.rtItemNumber.Size = new System.Drawing.Size(196, 44);
            this.rtItemNumber.TabIndex = 2;
            this.rtItemNumber.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Program3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtItemNumber);
            this.Controls.Add(this.rtGenderPrice);
            this.Controls.Add(this.btnGetData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.RichTextBox rtGenderPrice;
        private System.Windows.Forms.RichTextBox rtItemNumber;
        private System.Windows.Forms.Label label1;
    }
}

