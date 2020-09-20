namespace ProfitDetectorV2
{
    partial class ItemDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDisplay));
            this.ItemIcon = new System.Windows.Forms.PictureBox();
            this.item_name = new System.Windows.Forms.Label();
            this.item_profit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemIcon
            // 
            this.ItemIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("ItemIcon.InitialImage")));
            this.ItemIcon.Location = new System.Drawing.Point(10, 6);
            this.ItemIcon.MaximumSize = new System.Drawing.Size(75, 75);
            this.ItemIcon.Name = "ItemIcon";
            this.ItemIcon.Size = new System.Drawing.Size(75, 75);
            this.ItemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemIcon.TabIndex = 0;
            this.ItemIcon.TabStop = false;
            // 
            // item_name
            // 
            this.item_name.AutoSize = true;
            this.item_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name.ForeColor = System.Drawing.Color.White;
            this.item_name.Location = new System.Drawing.Point(91, 10);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(139, 29);
            this.item_name.TabIndex = 1;
            this.item_name.Text = "Item Name";
            // 
            // item_profit
            // 
            this.item_profit.AutoSize = true;
            this.item_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_profit.ForeColor = System.Drawing.Color.White;
            this.item_profit.Location = new System.Drawing.Point(91, 40);
            this.item_profit.Name = "item_profit";
            this.item_profit.Size = new System.Drawing.Size(123, 25);
            this.item_profit.TabIndex = 2;
            this.item_profit.Text = "Profit: 1212";
            // 
            // ItemDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.item_profit);
            this.Controls.Add(this.item_name);
            this.Controls.Add(this.ItemIcon);
            this.Name = "ItemDisplay";
            this.Size = new System.Drawing.Size(915, 88);
            ((System.ComponentModel.ISupportInitialize)(this.ItemIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ItemIcon;
        private System.Windows.Forms.Label item_name;
        private System.Windows.Forms.Label item_profit;
    }
}
