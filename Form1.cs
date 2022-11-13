using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            
            InitializeComponent();
            tabControl1.ItemSize = new Size(tabControl1.Size.Width / tabControl1.TabPages.Count - 1, tabControl1.ItemSize.Height);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
    }
}
