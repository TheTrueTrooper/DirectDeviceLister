namespace DirectDeviceLister
{
    partial class DirectDeviceListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrVi_List = new System.Windows.Forms.TreeView();
            this.Bu_RefreshList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrVi_List
            // 
            this.TrVi_List.Location = new System.Drawing.Point(12, 12);
            this.TrVi_List.Name = "TrVi_List";
            this.TrVi_List.Size = new System.Drawing.Size(776, 397);
            this.TrVi_List.TabIndex = 0;
            // 
            // Bu_RefreshList
            // 
            this.Bu_RefreshList.Location = new System.Drawing.Point(12, 415);
            this.Bu_RefreshList.Name = "Bu_RefreshList";
            this.Bu_RefreshList.Size = new System.Drawing.Size(776, 23);
            this.Bu_RefreshList.TabIndex = 1;
            this.Bu_RefreshList.Text = "Refresh List";
            this.Bu_RefreshList.UseVisualStyleBackColor = true;
            this.Bu_RefreshList.Click += new System.EventHandler(this.Bu_RefreshList_Click);
            // 
            // DirectDeviceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bu_RefreshList);
            this.Controls.Add(this.TrVi_List);
            this.Name = "DirectDeviceListForm";
            this.Text = "Direct Device List";
            this.Load += new System.EventHandler(this.DirectDeviceListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TrVi_List;
        private System.Windows.Forms.Button Bu_RefreshList;
    }
}

