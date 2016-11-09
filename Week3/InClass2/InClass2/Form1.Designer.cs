namespace InClass2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumOne = new System.Windows.Forms.TextBox();
            this.txtNumTwo = new System.Windows.Forms.TextBox();
            this.btnResults = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultOne = new System.Windows.Forms.Label();
            this.lblResultTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month(Enter 3)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year(Enter 2003)";
            // 
            // txtNumOne
            // 
            this.txtNumOne.Location = new System.Drawing.Point(153, 26);
            this.txtNumOne.Name = "txtNumOne";
            this.txtNumOne.Size = new System.Drawing.Size(100, 20);
            this.txtNumOne.TabIndex = 2;
            // 
            // txtNumTwo
            // 
            this.txtNumTwo.Location = new System.Drawing.Point(153, 70);
            this.txtNumTwo.Name = "txtNumTwo";
            this.txtNumTwo.Size = new System.Drawing.Size(100, 20);
            this.txtNumTwo.TabIndex = 3;
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(153, 110);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(100, 23);
            this.btnResults.TabIndex = 4;
            this.btnResults.Text = "Get Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(37, 166);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(109, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "3 Month Treasury Bill:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "6 Month Treasury Bill:";
            // 
            // lblResultOne
            // 
            this.lblResultOne.AutoSize = true;
            this.lblResultOne.Location = new System.Drawing.Point(144, 166);
            this.lblResultOne.Name = "lblResultOne";
            this.lblResultOne.Size = new System.Drawing.Size(0, 13);
            this.lblResultOne.TabIndex = 7;
            // 
            // lblResultTwo
            // 
            this.lblResultTwo.AutoSize = true;
            this.lblResultTwo.Location = new System.Drawing.Point(144, 190);
            this.lblResultTwo.Name = "lblResultTwo";
            this.lblResultTwo.Size = new System.Drawing.Size(0, 13);
            this.lblResultTwo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultTwo);
            this.Controls.Add(this.lblResultOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.txtNumTwo);
            this.Controls.Add(this.txtNumOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumOne;
        private System.Windows.Forms.TextBox txtNumTwo;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultOne;
        private System.Windows.Forms.Label lblResultTwo;
    }
}

