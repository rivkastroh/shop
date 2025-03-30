namespace UI
{
    partial class FinishAcount
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
            close = new Button();
            sum = new Label();
            thank = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // close
            // 
            close.ForeColor = Color.FromArgb(64, 0, 64);
            close.Location = new Point(43, 265);
            close.Name = "close";
            close.Size = new Size(75, 23);
            close.TabIndex = 0;
            close.Text = "סגור";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.Location = new Point(134, 98);
            sum.Name = "sum";
            sum.Size = new Size(87, 15);
            sum.TabIndex = 1;
            sum.Text = "לתשלום: 0 ש\"ח";
            // 
            // thank
            // 
            thank.AutoSize = true;
            thank.ForeColor = Color.DarkMagenta;
            thank.Location = new Point(91, 157);
            thank.Name = "thank";
            thank.Size = new Size(109, 15);
            thank.TabIndex = 2;
            thank.Text = "!תודה שקנית אצלינו";
            // 
            // button1
            // 
            button1.Location = new Point(190, 207);
            button1.Name = "button1";
            button1.Size = new Size(110, 46);
            button1.TabIndex = 3;
            button1.Text = "לראות את המשפטים שלי";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FinishAcount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 319);
            Controls.Add(button1);
            Controls.Add(thank);
            Controls.Add(sum);
            Controls.Add(close);
            Name = "FinishAcount";
            Text = "סיום חשבון";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close;
        private Label sum;
        private Label thank;
        private Button button1;
    }
}