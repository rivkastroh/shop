namespace UI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            manegerLogin = new Button();
            cashierLogin = new Button();
            enterPass = new Label();
            textBoxPass = new TextBox();
            SuspendLayout();
            // 
            // manegerLogin
            // 
            manegerLogin.Location = new Point(522, 132);
            manegerLogin.Name = "manegerLogin";
            manegerLogin.Size = new Size(75, 23);
            manegerLogin.TabIndex = 0;
            manegerLogin.Text = "מנהל";
            manegerLogin.UseVisualStyleBackColor = true;
            manegerLogin.Click += manegerLogin_Click;
            // 
            // cashierLogin
            // 
            cashierLogin.CausesValidation = false;
            cashierLogin.Location = new Point(231, 132);
            cashierLogin.Name = "cashierLogin";
            cashierLogin.Size = new Size(75, 23);
            cashierLogin.TabIndex = 1;
            cashierLogin.Text = "קופאי";
            cashierLogin.UseVisualStyleBackColor = true;
            cashierLogin.Click += cashierLogin_Click;
            // 
            // enterPass
            // 
            enterPass.AutoSize = true;
            enterPass.Location = new Point(488, 189);
            enterPass.Name = "enterPass";
            enterPass.Size = new Size(73, 15);
            enterPass.TabIndex = 2;
            enterPass.Text = "הכנס סיסמה";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(476, 211);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(100, 23);
            textBoxPass.TabIndex = 3;
            textBoxPass.KeyPress += textBoxPass_KeyPress;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cashierLogin);
            Controls.Add(manegerLogin);
            Name = "Login";
            Text = "כניסה";
            ResumeLayout(false);
        }

        #endregion

        private Button manegerLogin;
        private Button cashierLogin;
        private Label enterPass;
        private TextBox textBoxPass;
    }
}