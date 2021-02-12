namespace TechSupport.UserControls
{
    partial class OpenIncidentsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openIncidentsListView = new System.Windows.Forms.ListView();
            this.productCodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOpenedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.technicianColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // openIncidentsListView
            // 
            this.openIncidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productCodeColumn,
            this.dateOpenedHeader,
            this.customerColumn,
            this.technicianColumn,
            this.titleColumn});
            this.openIncidentsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openIncidentsListView.HideSelection = false;
            this.openIncidentsListView.Location = new System.Drawing.Point(0, 0);
            this.openIncidentsListView.Name = "openIncidentsListView";
            this.openIncidentsListView.Size = new System.Drawing.Size(599, 304);
            this.openIncidentsListView.TabIndex = 2;
            this.openIncidentsListView.UseCompatibleStateImageBehavior = false;
            this.openIncidentsListView.View = System.Windows.Forms.View.Details;
            // 
            // productCodeColumn
            // 
            this.productCodeColumn.Text = "Product Code";
            this.productCodeColumn.Width = 90;
            // 
            // dateOpenedHeader
            // 
            this.dateOpenedHeader.Text = "Date Opened";
            this.dateOpenedHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateOpenedHeader.Width = 90;
            // 
            // customerColumn
            // 
            this.customerColumn.Text = "Customer";
            this.customerColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerColumn.Width = 90;
            // 
            // technicianColumn
            // 
            this.technicianColumn.Text = "Technician";
            this.technicianColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.technicianColumn.Width = 90;
            // 
            // titleColumn
            // 
            this.titleColumn.Text = "Title";
            this.titleColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleColumn.Width = 235;
            // 
            // OpenIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openIncidentsListView);
            this.Name = "OpenIncidentsUserControl";
            this.Size = new System.Drawing.Size(599, 304);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView openIncidentsListView;
        private System.Windows.Forms.ColumnHeader productCodeColumn;
        private System.Windows.Forms.ColumnHeader dateOpenedHeader;
        private System.Windows.Forms.ColumnHeader customerColumn;
        private System.Windows.Forms.ColumnHeader technicianColumn;
        private System.Windows.Forms.ColumnHeader titleColumn;
    }
}