namespace UI
{
    partial class ManegerSale
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
            label1 = new Label();
            addSale = new Button();
            updateSale = new Button();
            removeSale = new Button();
            seeAllSale = new Button();
            lblId = new Label();
            lblBarcode = new Label();
            lblAmountGetSale = new Label();
            lblDiscount = new Label();
            lblIntendedAllCustomers = new Label();
            lblStartSale = new Label();
            lblFinishSale = new Label();
            txtId = new TextBox();
            txtBarcode = new TextBox();
            txtAmountGetSale = new TextBox();
            txtDiscount = new TextBox();
            chkIntendedAllCustomers = new CheckBox();
            dtpStartSale = new DateTimePicker();
            dtpFinishSale = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "ניהול מבצעים";
            // 
            // addSale
            // 
            addSale.Location = new Point(575, 140);
            addSale.Name = "addSale";
            addSale.Size = new Size(75, 23);
            addSale.TabIndex = 1;
            addSale.Text = "הוספה";
            addSale.UseVisualStyleBackColor = true;
            addSale.Click += addSale_Click;
            // 
            // updateSale
            // 
            updateSale.Location = new Point(382, 140);
            updateSale.Name = "updateSale";
            updateSale.Size = new Size(75, 23);
            updateSale.TabIndex = 2;
            updateSale.Text = "עדכון";
            updateSale.UseVisualStyleBackColor = true;
            updateSale.Click += updateSale_Click;
            // 
            // removeSale
            // 
            removeSale.Location = new Point(175, 140);
            removeSale.Name = "removeSale";
            removeSale.Size = new Size(75, 23);
            removeSale.TabIndex = 3;
            removeSale.Text = "הסרה";
            removeSale.UseVisualStyleBackColor = true;
            removeSale.Click += removeSale_Click;
            // 
            // seeAllSale
            // 
            seeAllSale.Location = new Point(12, 40);
            seeAllSale.Name = "seeAllSale";
            seeAllSale.Size = new Size(101, 50);
            seeAllSale.TabIndex = 4;
            seeAllSale.Text = "לראות את כלל המבצעים";
            seeAllSale.UseVisualStyleBackColor = true;
            seeAllSale.Click += seeAllSale_Click;

            // Initialize labels
            lblId = new Label { Text = "ID:", Location = new System.Drawing.Point(10, 200) };
            lblBarcode = new Label { Text = "Barcode:", Location = new System.Drawing.Point(10, 230) };
            lblAmountGetSale = new Label { Text = "Amount Get Sale:", Location = new System.Drawing.Point(10, 260) };
            lblDiscount = new Label { Text = "Discount:", Location = new System.Drawing.Point(10, 320) };
            lblIntendedAllCustomers = new Label { Text = "Intended All Customers:", Location = new System.Drawing.Point(10, 350) };
            lblStartSale = new Label { Text = "Start Sale:", Location = new System.Drawing.Point(10, 380) };
            lblFinishSale = new Label { Text = "Finish Sale:", Location = new System.Drawing.Point(10, 410) };

            // Initialize textboxes
            txtId = new TextBox { Location = new System.Drawing.Point(150, 200) };
            txtBarcode = new TextBox { Location = new System.Drawing.Point(150, 230) };
            txtAmountGetSale = new TextBox { Location = new System.Drawing.Point(150, 260) };
            txtDiscount = new TextBox { Location = new System.Drawing.Point(150, 320) };

            // Initialize checkbox
            chkIntendedAllCustomers = new CheckBox { Location = new System.Drawing.Point(150, 350) };

            // Initialize date time pickers
            dtpStartSale = new DateTimePicker { Location = new System.Drawing.Point(150, 380) };
            dtpFinishSale = new DateTimePicker { Location = new System.Drawing.Point(150, 410) };

            // 
            // ManegerSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(seeAllSale);
            Controls.Add(removeSale);
            Controls.Add(updateSale);
            Controls.Add(addSale);
            Controls.Add(label1);
            Name = "ManegerSale";
            Text = "ניהול מבצעים";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addSale;
        private Button updateSale;
        private Button removeSale;
        private Button seeAllSale;

        private Label lblId;
        private Label lblBarcode;
        private Label lblAmountGetSale;
        private Label lblDiscount;
        private Label lblIntendedAllCustomers;
        private Label lblStartSale;
        private Label lblFinishSale;

        private TextBox txtId;
        private TextBox txtBarcode;
        private TextBox txtAmountGetSale;
        private TextBox txtDiscount;
        private CheckBox chkIntendedAllCustomers;
        private DateTimePicker dtpStartSale;
        private DateTimePicker dtpFinishSale;
    }
}