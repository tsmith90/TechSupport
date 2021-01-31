
namespace TechSupport.UserControls
{
    partial class SearchIncidentUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.incidentSearchButton = new System.Windows.Forms.Button();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.cancelSearchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.48148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.51852F));
            this.tableLayoutPanel1.Controls.Add(this.incidentDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.incidentSearchButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerIDLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancelSearchButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 318);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.AllowUserToAddRows = false;
            this.incidentDataGridView.AllowUserToDeleteRows = false;
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.incidentDataGridView, 2);
            this.incidentDataGridView.Location = new System.Drawing.Point(3, 108);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.ReadOnly = true;
            this.incidentDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.incidentDataGridView.Size = new System.Drawing.Size(363, 202);
            this.incidentDataGridView.TabIndex = 0;
            this.incidentDataGridView.TabStop = false;
            // 
            // incidentSearchButton
            // 
            this.incidentSearchButton.Location = new System.Drawing.Point(3, 3);
            this.incidentSearchButton.Name = "incidentSearchButton";
            this.incidentSearchButton.Size = new System.Drawing.Size(141, 62);
            this.incidentSearchButton.TabIndex = 4;
            this.incidentSearchButton.Text = "Search Incidents";
            this.incidentSearchButton.UseVisualStyleBackColor = true;
            this.incidentSearchButton.Click += new System.EventHandler(this.IncidentSearchButton_Click);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(3, 69);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(141, 23);
            this.customerIDLabel.TabIndex = 2;
            this.customerIDLabel.Text = "customerID:";
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.Location = new System.Drawing.Point(150, 3);
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(157, 63);
            this.cancelSearchButton.TabIndex = 5;
            this.cancelSearchButton.Text = "Clear Search";
            this.cancelSearchButton.UseVisualStyleBackColor = true;
            this.cancelSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(150, 72);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(197, 20);
            this.searchTextBox.TabIndex = 6;
            // 
            // SearchIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchIncidentUserControl";
            this.Size = new System.Drawing.Size(475, 324);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView incidentDataGridView;
        private System.Windows.Forms.Button incidentSearchButton;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button cancelSearchButton;
    }
}
