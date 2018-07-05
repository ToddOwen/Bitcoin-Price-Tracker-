namespace BitcoinPriceTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PriceText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PriceText
            // 
            this.PriceText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PriceText.AutoSize = true;
            this.PriceText.Font = new System.Drawing.Font("Segoe UI Black", 42F, System.Drawing.FontStyle.Bold);
            this.PriceText.ForeColor = System.Drawing.Color.DarkOrange;
            this.PriceText.Location = new System.Drawing.Point(206, 49);
            this.PriceText.Margin = new System.Windows.Forms.Padding(40);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(294, 74);
            this.PriceText.TabIndex = 0;
            this.PriceText.Text = "PriceText";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(750, 200);
            this.Controls.Add(this.PriceText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceText;
    }
}

