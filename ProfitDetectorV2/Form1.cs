using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitDetectorV2
{
    public partial class Form1 : Form
    {
        APIContent data;


        private SizeF scale = new SizeF(1.0f, 1.0f);
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            scale = new SizeF(scale.Width * factor.Width, scale.Height * factor.Height);
            base.ScaleControl(factor, specified);
        }

        // Recursively search for SplitContainer controls
        private void Fix(Control c) {
            foreach (Control child in c.Controls) {
                if (child is SplitContainer) {
                    SplitContainer sp = (SplitContainer)child;
                    Fix(sp);
                    Fix(sp.Panel1);
                    Fix(sp.Panel2);
                } else {
                    Fix(child);
                }
            }
        }
        private void Fix(SplitContainer sp) {
            // Scale factor depends on orientation
            float sc = (sp.Orientation == Orientation.Vertical) ? scale.Width : scale.Height;
            if (sp.FixedPanel == FixedPanel.Panel1) {
                sp.SplitterDistance = (int)Math.Round((float)sp.SplitterDistance * sc);
            } else if (sp.FixedPanel == FixedPanel.Panel2) {
                int cs = (sp.Orientation == Orientation.Vertical) ? sp.Panel2.ClientSize.Width : sp.Panel2.ClientSize.Height;
                int newcs = (int)((float)cs * sc);
                sp.SplitterDistance -= (newcs - cs);
            }
        }

        public void updateData() {
            data = new APIContent(searchSettings.constructFilterFromSettings(), profitResults);
        }

        public Form1() {
            InitializeComponent();
            updateData();
        }

        private void RefreshData_MouseDown(object sender, MouseEventArgs e) {
            RefreshData.ForeColor = Color.Gray;
            updateData();
        }

        private void RefreshData_MouseLeave(object sender, EventArgs e) {
            RefreshData.ForeColor = Color.White;
        }

        private void RefreshData_MouseEnter(object sender, EventArgs e) {
            RefreshData.ForeColor = Color.DarkGray;
        }

        private void RefreshData_MouseUp(object sender, MouseEventArgs e) {
            RefreshData.ForeColor = Color.DarkGray;
        }

        private void SearchSettings_Load(object sender, EventArgs e) {

        }

        private void Form1_Shown(object sender, EventArgs e) {
            Fix(this);
        }
    }
}
