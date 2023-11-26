using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifPersian
{
    public partial class frmView : Form
    {
        private DialogResult _result;

        public frmView()
        {
            InitializeComponent();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            SetFont(this.Controls);

        }
        public static void SetFont(Control.ControlCollection cntCll)
        {
            var pfc = new PrivateFontCollection();
            var fontLength = Properties.Resources.IRANSansWeb_FaNum__Medium.Length;
            var fontData = Properties.Resources.IRANSansWeb_FaNum__Medium;
            var data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            Marshal.FreeCoTaskMem(data);
            foreach (object obj in cntCll)
            {
                if (obj is Panel panel)
                {
                    panel.Font = new Font(pfc.Families[0], panel.Font.Size);
                    SetTabIndex(panel.Controls, panel.Tag != null);
                }
            }
        }
        public static void SetTabIndex(Control.ControlCollection cntCll, bool TabStop)
        {
            foreach (object obj in cntCll)
                if (obj is Button button)
                    button.TabStop = TabStop;
        }

        public DialogResult Result
        {
            get { return _result; }
        }

        public Label Label
        {
            get { return _label; }
            set { _label = value; }
        }

        public PictureBox icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public Panel OKPanel
        {
            get { return _okPanel; }
            set { _okPanel = value; }
        }

        public Panel OKCancelPanel
        {
            get { return _okCancelPanel; }
            set { _okCancelPanel = value; }
        }

        public Panel RetryCancelPanel
        {
            get { return _retryCancelPanel; }
            set { _retryCancelPanel = value; }
        }

        public Panel YesNoPanel
        {
            get { return _yesNoPanel; }
            set { _yesNoPanel = value; }
        }

        public Panel YesNoCancelPanel
        {
            get { return _yesNoCancelPanel; }
            set { _yesNoCancelPanel = value; }
        }

        private void OkPanelOKBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
            this.Close();
        }

        private void OkCancelPanelCancelBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            this.Close();
        }

        private void RetryCancelPanelCancelBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            this.Close();
        }

        private void YesNoCancelPanelCancelBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            this.Close();
        }

        private void OkPanelOKBtn_Click_1(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
            this.Close();
        }

        private void OkCancelPanelOKBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
            this.Close();
        }

        private void RetryCancelPanelRetryBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Retry;
            this.Close();
        }

        private void YesNoCancelPanelNoBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.No;
            this.Close();
        }

        private void YesNoCancelPanelYesBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Yes;
            this.Close();
        }

        private void YesNoPanelNoBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.No;
            this.Close();
        }

        private void YesNoPanelYesBtn_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Yes;
            this.Close();
        }

    }
}
