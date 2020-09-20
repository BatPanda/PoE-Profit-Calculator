namespace ProfitDetectorV2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RefreshData = new System.Windows.Forms.Button();
            this.profitResults = new ProfitDetectorV2.ProfitResultsControl();
            this.searchSettings = new ProfitDetectorV2.SearchSettingsControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshData
            // 
            this.RefreshData.AutoSize = true;
            this.RefreshData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshData.BackgroundImage")));
            this.RefreshData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RefreshData.FlatAppearance.BorderSize = 0;
            this.RefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshData.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshData.ForeColor = System.Drawing.Color.White;
            this.RefreshData.Location = new System.Drawing.Point(0, 0);
            this.RefreshData.Name = "RefreshData";
            this.RefreshData.Size = new System.Drawing.Size(1323, 59);
            this.RefreshData.TabIndex = 0;
            this.RefreshData.Text = "Refresh live data";
            this.RefreshData.UseVisualStyleBackColor = true;
            this.RefreshData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RefreshData_MouseDown);
            this.RefreshData.MouseEnter += new System.EventHandler(this.RefreshData_MouseEnter);
            this.RefreshData.MouseLeave += new System.EventHandler(this.RefreshData_MouseLeave);
            this.RefreshData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RefreshData_MouseUp);
            // 
            // profitResults
            // 
            this.profitResults.AutoSize = true;
            this.profitResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profitResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.profitResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profitResults.Location = new System.Drawing.Point(0, 0);
            this.profitResults.Name = "profitResults";
            this.profitResults.Size = new System.Drawing.Size(1004, 750);
            this.profitResults.TabIndex = 2;
            // 
            // searchSettings
            // 
            this.searchSettings.AutoSize = true;
            this.searchSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.searchSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchSettings.Location = new System.Drawing.Point(0, 0);
            this.searchSettings.Name = "searchSettings";
            this.searchSettings.Size = new System.Drawing.Size(315, 750);
            this.searchSettings.TabIndex = 1;
            this.searchSettings.Load += new System.EventHandler(this.SearchSettings_Load);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RefreshData);
            this.splitContainer1.Size = new System.Drawing.Size(1323, 813);
            this.splitContainer1.SplitterDistance = 750;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.searchSettings);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.profitResults);
            this.splitContainer2.Size = new System.Drawing.Size(1323, 750);
            this.splitContainer2.SplitterDistance = 315;
            this.splitContainer2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1323, 813);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Profit Calc v2.0 - TRBatpanda";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RefreshData;
        public SearchSettingsControl searchSettings;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public ProfitResultsControl profitResults;
    }
}

