namespace UI
{
    partial class CashierInterface
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
            seeAllProd = new Button();
            addCustomer = new Button();
            removeCustomer = new Button();
            updateCustomer = new Button();
            seeAllCustomer = new Button();
            newAccount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 45);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "שלום! מה אתה רוצה לעשות";
            // 
            // seeAllProd
            // 
            seeAllProd.Location = new Point(582, 88);
            seeAllProd.Name = "seeAllProd";
            seeAllProd.Size = new Size(150, 34);
            seeAllProd.TabIndex = 1;
            seeAllProd.Text = "לראות קטלוג מוצרים";
            seeAllProd.UseVisualStyleBackColor = true;
            seeAllProd.Click += seeAllProd_Click;
            // 
            // addCustomer
            // 
            addCustomer.Location = new Point(458, 140);
            addCustomer.Name = "addCustomer";
            addCustomer.Size = new Size(108, 42);
            addCustomer.TabIndex = 2;
            addCustomer.Text = "לצרף לקוח למועדון";
            addCustomer.UseVisualStyleBackColor = true;
            addCustomer.Click += addCustomer_Click;
            // 
            // removeCustomer
            // 
            removeCustomer.Location = new Point(308, 140);
            removeCustomer.Name = "removeCustomer";
            removeCustomer.Size = new Size(113, 42);
            removeCustomer.TabIndex = 3;
            removeCustomer.Text = "להסיר לקוח מהמועדון";
            removeCustomer.UseVisualStyleBackColor = true;
            removeCustomer.Click += removeCustomer_Click;
            // 
            // updateCustomer
            // 
            updateCustomer.Location = new Point(169, 140);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Size = new Size(108, 42);
            updateCustomer.TabIndex = 4;
            updateCustomer.Text = "לעדכן פרטי לקוח";
            updateCustomer.UseVisualStyleBackColor = true;
            updateCustomer.Click += updateCustomer_Click;
            // 
            // seeAllCustomer
            // 
            seeAllCustomer.Location = new Point(31, 140);
            seeAllCustomer.Name = "seeAllCustomer";
            seeAllCustomer.Size = new Size(111, 42);
            seeAllCustomer.TabIndex = 5;
            seeAllCustomer.Text = "לראות את כל הלקוחות";
            seeAllCustomer.UseVisualStyleBackColor = true;
            seeAllCustomer.Click += seeAllCustomer_Click;
            // 
            // newAccount
            // 
            newAccount.Location = new Point(205, 221);
            newAccount.Name = "newAccount";
            newAccount.Size = new Size(103, 32);
            newAccount.TabIndex = 6;
            newAccount.Text = "לבצע חשבון";
            newAccount.UseVisualStyleBackColor = true;
            newAccount.Click += newAccount_Click;
            // 
            // CashierInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newAccount);
            Controls.Add(seeAllCustomer);
            Controls.Add(updateCustomer);
            Controls.Add(removeCustomer);
            Controls.Add(addCustomer);
            Controls.Add(seeAllProd);
            Controls.Add(label1);
            //עוד
            cancel = new Button { Text = "ביטול", Location = new Point(580, 225) };
            cancel.Click += Cancel;

            Name = "CashierInterface";
            Text = "ממשק קופאי";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button seeAllProd;
        private Button addCustomer;
        private Button removeCustomer;
        private Button updateCustomer;
        private Button seeAllCustomer;
        private Button newAccount;
        private Button cancel;
        private Button submitButton;


        Label identityLabel = new Label { Text = "Identity:", Location = new Point(450, 190) };
        TextBox identityInput = new TextBox { Location = new Point(450, 215) };

        Label nameLabel = new Label { Text = "Name:", Location = new Point(450, 255) };
        TextBox nameInput = new TextBox { Location = new Point(450, 280) };

        Label addressLabel = new Label { Text = "Address:", Location = new Point(450, 310) };
        TextBox addressInput = new TextBox { Location = new Point(450, 335) };

        Label phoneNumberLabel = new Label { Text = "Phone Number:", Location = new Point(450, 365) };
        TextBox phoneNumberInput = new TextBox { Location = new Point(450, 390) };


        //Label identityLabel = new Label { Text = "Identity:" };
        //TextBox identityInput = new TextBox();

        //Label nameLabel = new Label { Text = "Name:" };
        //TextBox nameInput = new TextBox();

        //Label addressLabel = new Label { Text = "Address:" };
        //TextBox addressInput = new TextBox();

        //Label phoneNumberLabel = new Label { Text = "Phone Number:" };
        //TextBox phoneNumberInput = new TextBox();

    }
}