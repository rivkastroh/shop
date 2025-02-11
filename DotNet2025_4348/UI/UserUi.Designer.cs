namespace UI
{
    partial class UserUi
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
            maneger = new Button();
            cashier = new Button();
            SuspendLayout();
            // 
            // maneger
            // 
            maneger.Location = new Point(526, 207);
            maneger.Name = "maneger";
            maneger.Size = new Size(75, 23);
            maneger.TabIndex = 0;
            maneger.Text = "מנהל";
            maneger.UseVisualStyleBackColor = true;
            maneger.Click += maneger_Click;
            // 
            // cashier
            // 
            cashier.Location = new Point(230, 207);
            cashier.Name = "cashier";
            cashier.Size = new Size(75, 23);
            cashier.TabIndex = 1;
            cashier.Text = "קופאי";
            cashier.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cashier);
            Controls.Add(maneger);
            Name = "Login";
            Size = new Size(800, 450);
            Load += UserControl1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button maneger;
        private Button cashier;
    }
}
