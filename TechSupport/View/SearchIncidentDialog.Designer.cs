
namespace TechSupport.View
{
    partial class SearchIncidentDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.incidentSearchButton = new System.Windows.Forms.Button();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.cancelSearchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.87866F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.12134F));
            this.tableLayoutPanel1.Controls.Add(this.incidentDataGridView, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.incidentSearchButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerIDLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cancelSearchButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.19658F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.80342F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.AllowUserToAddRows = false;
            this.incidentDataGridView.AllowUserToDeleteRows = false;
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentDataGridView.Location = new System.Drawing.Point(11, 147);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.ReadOnly = true;
            this.incidentDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.incidentDataGridView.Size = new System.Drawing.Size(284, 202);
            this.incidentDataGridView.TabIndex = 0;
            // 
            // incidentSearchButton
            // 
            this.incidentSearchButton.Location = new System.Drawing.Point(11, 3);
            this.incidentSearchButton.Name = "incidentSearchButton";
            this.incidentSearchButton.Size = new System.Drawing.Size(143, 62);
            this.incidentSearchButton.TabIndex = 1;
            this.incidentSearchButton.Text = "Search Incidents";
            this.incidentSearchButton.UseVisualStyleBackColor = true;
            this.incidentSearchButton.Click += new System.EventHandler(this.incidentSearchButton_Click);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(11, 102);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(141, 19);
            this.customerIDLabel.TabIndex = 2;
            this.customerIDLabel.Text = "customerID:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(11, 124);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(197, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.Location = new System.Drawing.Point(301, 3);
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(157, 63);
            this.cancelSearchButton.TabIndex = 2;
            this.cancelSearchButton.Text = "Cancel Search";
            this.cancelSearchButton.UseVisualStyleBackColor = true;
            this.cancelSearchButton.Click += new System.EventHandler(this.cancelSearchButton_Click);
            // 
            // SearchIncidentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchIncidentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchIncidents";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button incidentSearchButton;
        private System.Windows.Forms.Button cancelSearchButton;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView incidentDataGridView;
    }
}