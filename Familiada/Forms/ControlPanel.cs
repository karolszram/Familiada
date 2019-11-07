using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Familiada
{
    public partial class ControlPanel : DevExpress.XtraEditors.XtraForm
    {
        private static ControlPanel instance;

        public ControlPanel Instance
        {
            get
            {
                if (instance != null) return instance;
                instance = new ControlPanel();
                return instance;
            }
        }


        public ControlPanel()
        {
            InitializeComponent();

            XmlDocument xml = new XmlDocument();


            

        }
    }
}
