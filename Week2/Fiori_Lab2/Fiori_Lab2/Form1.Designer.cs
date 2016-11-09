namespace Fiori_Lab2
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
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.rtBilling = new System.Windows.Forms.RichTextBox();
            this.rtShipping = new System.Windows.Forms.RichTextBox();
            this.rtItem = new System.Windows.Forms.RichTextBox();
            this.lblItemsBought = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.Black;
            this.btnBilling.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBilling.Location = new System.Drawing.Point(12, 23);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(174, 41);
            this.btnBilling.TabIndex = 0;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnShipping
            // 
            this.btnShipping.BackColor = System.Drawing.Color.Black;
            this.btnShipping.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShipping.Location = new System.Drawing.Point(260, 23);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(174, 41);
            this.btnShipping.TabIndex = 1;
            this.btnShipping.Text = "Shipping";
            this.btnShipping.UseVisualStyleBackColor = false;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.Black;
            this.btnItems.ForeColor = System.Drawing.SystemColors.Control;
            this.btnItems.Location = new System.Drawing.Point(136, 229);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(174, 42);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "Item";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // rtBilling
            // 
            this.rtBilling.BackColor = System.Drawing.Color.DarkGray;
            this.rtBilling.Location = new System.Drawing.Point(12, 79);
            this.rtBilling.Name = "rtBilling";
            this.rtBilling.Size = new System.Drawing.Size(174, 144);
            this.rtBilling.TabIndex = 3;
            this.rtBilling.Text = "";
            // 
            // rtShipping
            // 
            this.rtShipping.BackColor = System.Drawing.Color.DarkGray;
            this.rtShipping.Location = new System.Drawing.Point(260, 79);
            this.rtShipping.Name = "rtShipping";
            this.rtShipping.Size = new System.Drawing.Size(174, 144);
            this.rtShipping.TabIndex = 4;
            this.rtShipping.Text = "";
            // 
            // rtItem
            // 
            this.rtItem.BackColor = System.Drawing.Color.Red;
            this.rtItem.Location = new System.Drawing.Point(13, 277);
            this.rtItem.Name = "rtItem";
            this.rtItem.Size = new System.Drawing.Size(421, 113);
            this.rtItem.TabIndex = 5;
            this.rtItem.Text = "";
            // 
            // lblItemsBought
            // 
            this.lblItemsBought.AutoSize = true;
            this.lblItemsBought.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblItemsBought.Location = new System.Drawing.Point(12, 229);
            this.lblItemsBought.Name = "lblItemsBought";
            this.lblItemsBought.Size = new System.Drawing.Size(35, 13);
            this.lblItemsBought.TabIndex = 6;
            this.lblItemsBought.Text = "label1";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCost.Location = new System.Drawing.Point(326, 229);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 13);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(446, 402);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblItemsBought);
            this.Controls.Add(this.rtItem);
            this.Controls.Add(this.rtShipping);
            this.Controls.Add(this.rtBilling);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.btnBilling);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnShipping;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.RichTextBox rtBilling;
        private System.Windows.Forms.RichTextBox rtShipping;
        private System.Windows.Forms.RichTextBox rtItem;
        private System.Windows.Forms.Label lblItemsBought;
        private System.Windows.Forms.Label lblCost;
    }
}

