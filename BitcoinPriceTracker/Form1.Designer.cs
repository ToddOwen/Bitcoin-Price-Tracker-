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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PriceText = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.CoinDeskAPITimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceText
            // 
            this.PriceText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PriceText.AutoSize = true;
            this.PriceText.Font = new System.Drawing.Font("Segoe UI Black", 42F, System.Drawing.FontStyle.Bold);
            this.PriceText.ForeColor = System.Drawing.Color.DarkOrange;
            this.PriceText.Location = new System.Drawing.Point(197, 49);
            this.PriceText.Margin = new System.Windows.Forms.Padding(40);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(294, 74);
            this.PriceText.TabIndex = 0;
            this.PriceText.Text = "PriceText";
            // 
            // image
            // 
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.Location = new System.Drawing.Point(21, 32);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(189, 179);
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // CoinDeskAPITimer
            // 
            this.CoinDeskAPITimer.Enabled = true;
            this.CoinDeskAPITimer.Interval = 50;
            this.CoinDeskAPITimer.Tick += new System.EventHandler(this.CoinDeskAPITimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(750, 192);
            this.Controls.Add(this.image);
            this.Controls.Add(this.PriceText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.6D;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Timer CoinDeskAPITimer;
    }
}

