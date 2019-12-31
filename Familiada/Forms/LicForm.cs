using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Familiada.Forms
{
    public partial class LicForm : Form
    {
        public LicForm()
        {
            InitializeComponent();
        }

        private void LicBtn_Click(object sender, EventArgs e)
        {
            if (LicTextBox.Text == "311219acceptance")
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Familiada", "", true);
            }
            this.Close();
        }
    }
}
