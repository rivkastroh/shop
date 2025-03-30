namespace UI
{
    partial class Acount
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
            addProd = new Button();
            inputBarcode = new TextBox();
            finishAcount = new Button();
            sum = new Label();
            SuspendLayout();
            // 
            // addProd
            // 
            addProd.Location = new Point(191, 125);
            addProd.Name = "addProd";
            addProd.Size = new Size(106, 23);
            addProd.TabIndex = 0;
            addProd.Text = "הוסף מוצר";
            addProd.UseVisualStyleBackColor = true;
            addProd.Click += addProd_Click;
            // 
            // inputBarcode
            // 
            inputBarcode.Location = new Point(318, 125);
            inputBarcode.Name = "inputBarcode";
            inputBarcode.Size = new Size(100, 23);
            inputBarcode.TabIndex = 1;
            inputBarcode.KeyDown += new KeyEventHandler(input_KeyDown);
            // 
            // finishAcount
            // 
            finishAcount.Location = new Point(80, 298);
            finishAcount.Name = "finishAcount";
            finishAcount.Size = new Size(105, 39);
            finishAcount.TabIndex = 2;
            finishAcount.Text = "סיום ותשלום";
            finishAcount.UseVisualStyleBackColor = true;
            finishAcount.Click += finishAcount_Click;
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.Location = new Point(90, 258);
            sum.Name = "sum";
            sum.Size = new Size(97, 15);
            sum.TabIndex = 3;
            sum.Text = "סכום כולל: 0 ש\"ח";
            // 
            // Acount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 451);
            Controls.Add(sum);
            Controls.Add(finishAcount);
            Controls.Add(inputBarcode);
            Controls.Add(addProd);
            Name = "Acount";
            Text = "חשבון";
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //this.MouseDown += new MouseEventHandler(Form1_MouseDown);

        private Button addProd;
        private TextBox inputBarcode;
        private Button finishAcount;
        private Label sum;
        private ContextMenuStrip contextMenu;
    }
}