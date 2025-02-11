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
    public partial class ShowObj<T> : Form
    {
        public ShowObj(IEnumerable<T> objs)
        {
            InitializeComponent();

            foreach (var obj in objs)
            {
                this.listBoxObj.Items.Add(obj.ToString());
            }

        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            // הגדרת אחוזים לגובה ורוחב ה-ListBox
            float widthPercentage = 0.95f; // 20% מהרוחב
            float heightPercentage = 0.95f; // 40% מהגובה

            // עדכון גודל ה-ListBox
            listBoxObj.Size = new Size((int)(this.ClientSize.Width * widthPercentage),
                                        (int)(this.ClientSize.Height * heightPercentage));
        }
    }
}
