using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // בדוק אם המקש שנלחץ הוא Enter
            {
                string password = this.textBoxPass.Text;
                if (password == "1234")
                {
                    ManegerInterface manegerInterface = new ManegerInterface(this);
                    manegerInterface.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("סיסמה שגויה!");
                    textBoxPass.Text = "";
                }
            }
        }
        private void manegerLogin_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.enterPass);
            this.Controls.Add(this.textBoxPass);
        }
    }
}
