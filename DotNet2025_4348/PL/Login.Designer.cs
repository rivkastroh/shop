namespace PL
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterManeger = new System.Windows.Forms.Button();
            this.enterCashier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterManeger
            // 
            this.enterManeger.Location = new System.Drawing.Point(547, 235);
            this.enterManeger.Name = "enterManeger";
            this.enterManeger.Size = new System.Drawing.Size(75, 23);
            this.enterManeger.TabIndex = 0;
            this.enterManeger.Text = "מנהל";
            this.enterManeger.UseVisualStyleBackColor = true;
            this.enterManeger.Click += new System.EventHandler(this.enterManeger_Click);
            // 
            // enterCashier
            // 
            this.enterCashier.Location = new System.Drawing.Point(212, 235);
            this.enterCashier.Name = "enterCashier";
            this.enterCashier.Size = new System.Drawing.Size(75, 23);
            this.enterCashier.TabIndex = 1;
            this.enterCashier.Text = "קופאי";
            this.enterCashier.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enterCashier);
            this.Controls.Add(this.enterManeger);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterManeger;
        private System.Windows.Forms.Button enterCashier;
    }
}
