

namespace TechSupport.UserControls
{
    partial class TechnicianIncidentsUserControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label technicianEmailLabel;
            System.Windows.Forms.Label technicianNameLabel;
            System.Windows.Forms.Label technicianPhoneLabel;
            this.technicianEmailTextBox = new System.Windows.Forms.TextBox();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technicianNameComboBox = new System.Windows.Forms.ComboBox();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technicianPhoneTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.technicianBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            technicianEmailLabel = new System.Windows.Forms.Label();
            technicianNameLabel = new System.Windows.Forms.Label();
            technicianPhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // technicianEmailLabel
            // 
            technicianEmailLabel.AutoSize = true;
            technicianEmailLabel.Location = new System.Drawing.Point(14, 63);
            technicianEmailLabel.Name = "technicianEmailLabel";
            technicianEmailLabel.Size = new System.Drawing.Size(35, 13);
            technicianEmailLabel.TabIndex = 1;
            technicianEmailLabel.Text = "Email:";
            // 
            // technicianNameLabel
            // 
            technicianNameLabel.AutoSize = true;
            technicianNameLabel.Location = new System.Drawing.Point(14, 19);
            technicianNameLabel.Name = "technicianNameLabel";
            technicianNameLabel.Size = new System.Drawing.Size(38, 13);
            technicianNameLabel.TabIndex = 5;
            technicianNameLabel.Text = "Name:";
            // 
            // technicianPhoneLabel
            // 
            technicianPhoneLabel.AutoSize = true;
            technicianPhoneLabel.Location = new System.Drawing.Point(14, 103);
            technicianPhoneLabel.Name = "technicianPhoneLabel";
            technicianPhoneLabel.Size = new System.Drawing.Size(41, 13);
            technicianPhoneLabel.TabIndex = 7;
            technicianPhoneLabel.Text = "Phone:";
            // 
            // technicianEmailTextBox
            // 
            this.technicianEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "TechnicianEmail", true));
            this.technicianEmailTextBox.Location = new System.Drawing.Point(66, 66);
            this.technicianEmailTextBox.Name = "technicianEmailTextBox";
            this.technicianEmailTextBox.ReadOnly = true;
            this.technicianEmailTextBox.Size = new System.Drawing.Size(270, 20);
            this.technicianEmailTextBox.TabIndex = 2;
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataSource = typeof(TechSupport.Model.Technician);
            // 
            // technicianNameComboBox
            // 
            this.technicianNameComboBox.DataSource = this.technicianBindingSource;
            this.technicianNameComboBox.DisplayMember = "TechnicianName";
            this.technicianNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicianNameComboBox.FormattingEnabled = true;
            this.technicianNameComboBox.Location = new System.Drawing.Point(66, 22);
            this.technicianNameComboBox.Name = "technicianNameComboBox";
            this.technicianNameComboBox.Size = new System.Drawing.Size(270, 21);
            this.technicianNameComboBox.TabIndex = 6;
            this.technicianNameComboBox.ValueMember = "TechnicianID";
            this.technicianNameComboBox.SelectedIndexChanged += new System.EventHandler(this.TechnicianNameComboBox_SelectedIndexChanged);
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataSource = typeof(TechSupport.Model.Incident);
            // 
            // technicianPhoneTextBox
            // 
            this.technicianPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "TechnicianPhone", true));
            this.technicianPhoneTextBox.Location = new System.Drawing.Point(66, 106);
            this.technicianPhoneTextBox.Name = "technicianPhoneTextBox";
            this.technicianPhoneTextBox.ReadOnly = true;
            this.technicianPhoneTextBox.Size = new System.Drawing.Size(144, 20);
            this.technicianPhoneTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 451F));
            this.tableLayoutPanel1.Controls.Add(this.incidentDataGridView, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.technicianPhoneTextBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.technicianEmailTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(technicianEmailLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.technicianNameComboBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(technicianNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(technicianPhoneLabel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 460);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.AllowUserToAddRows = false;
            this.incidentDataGridView.AllowUserToDeleteRows = false;
            this.incidentDataGridView.AutoGenerateColumns = false;
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn10});
            this.tableLayoutPanel1.SetColumnSpan(this.incidentDataGridView, 2);
            this.incidentDataGridView.DataSource = this.incidentBindingSource;
            this.incidentDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.incidentDataGridView.Location = new System.Drawing.Point(14, 174);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.ReadOnly = true;
            this.incidentDataGridView.Size = new System.Drawing.Size(568, 272);
            this.incidentDataGridView.TabIndex = 8;
            // 
            // technicianBindingSource1
            // 
            this.technicianBindingSource1.DataSource = typeof(TechSupport.Model.Technician);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn10.HeaderText = "Title";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustomerName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateOpened";
            this.dataGridViewTextBoxColumn8.HeaderText = "DateOpened";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // TechnicianIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TechnicianIncidentsUserControl";
            this.Size = new System.Drawing.Size(600, 484);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource technicianBindingSource;
        private System.Windows.Forms.TextBox technicianEmailTextBox;
        private System.Windows.Forms.ComboBox technicianNameComboBox;
        private System.Windows.Forms.TextBox technicianPhoneTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView incidentDataGridView;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private System.Windows.Forms.BindingSource technicianBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}