using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification
{
    public partial class frmView : Form
    {
        public void InitFont()
        {
            var pfc = new PrivateFontCollection();
            var fontLength = Properties.Resources.IRANSansWeb_FaNum__Medium.Length;
            var fontData = Properties.Resources.IRANSansWeb_FaNum__Medium;
            var data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            Marshal.FreeCoTaskMem(data);
            button1.Font = new Font(pfc.Families[0], button1.Font.Size);
        }
        public frmView()
        {
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {

        }
    }
}
