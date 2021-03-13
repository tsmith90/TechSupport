

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
            this.technicianPhoneTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            technicianEmailLabel = new System.Windows.Forms.Label();
            technicianNameLabel = new System.Windows.Forms.Label();
            technicianPhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // technicianEmailLabel
            // 
            technicianEmailLabel.AutoSize = true;
            technicianEmailLabel.Location = new System.Drawing.Point(14, 74);
            technicianEmailLabel.Name = "technicianEmailLabel";
            technicianEmailLabel.Size = new System.Drawing.Size(35, 13);
            technicianEmailLabel.TabIndex = 1;
            technicianEmailLabel.Text = "Email:";
            // 
            // technicianNameLabel
            // 
            technicianNameLabel.AutoSize = true;
            technicianNameLabel.Location = new System.Drawing.Point(14, 34);
            technicianNameLabel.Name = "technicianNameLabel";
            technicianNameLabel.Size = new System.Drawing.Size(38, 13);
            technicianNameLabel.TabIndex = 5;
            technicianNameLabel.Text = "Name:";
            // 
            // technicianPhoneLabel
            // 
            technicianPhoneLabel.AutoSize = true;
            technicianPhoneLabel.Location = new System.Drawing.Point(14, 117);
            technicianPhoneLabel.Name = "technicianPhoneLabel";
            technicianPhoneLabel.Size = new System.Drawing.Size(41, 13);
            technicianPhoneLabel.TabIndex = 7;
            technicianPhoneLabel.Text = "Phone:";
            // 
            // technicianEmailTextBox
            // 
            this.technicianEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "TechnicianEmail", true));
            this.technicianEmailTextBox.Location = new System.Drawing.Point(67, 77);
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
            this.technicianNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.technicianBindingSource, "TechnicianName", true));
            this.technicianNameComboBox.DataSource = this.technicianBindingSource;
            this.technicianNameComboBox.DisplayMember = "TechnicianName";
            this.technicianNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicianNameComboBox.FormattingEnabled = true;
            this.technicianNameComboBox.Location = new System.Drawing.Point(67, 37);
            this.technicianNameComboBox.Name = "technicianNameComboBox";
            this.technicianNameComboBox.Size = new System.Drawing.Size(270, 21);
            this.technicianNameComboBox.TabIndex = 6;
            this.technicianNameComboBox.ValueMember = "TechnicianName";
            this.technicianNameComboBox.SelectedIndexChanged += new System.EventHandler(this.technicianNameComboBox_SelectedIndexChanged);
            // 
            // technicianPhoneTextBox
            // 
            this.technicianPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "TechnicianPhone", true));
            this.technicianPhoneTextBox.Location = new System.Drawing.Point(67, 120);
            this.technicianPhoneTextBox.Name = "technicianPhoneTextBox";
            this.technicianPhoneTextBox.ReadOnly = true;
            this.technicianPhoneTextBox.Size = new System.Drawing.Size(144, 20);
            this.technicianPhoneTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Controls.Add(this.technicianPhoneTextBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.technicianEmailTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(technicianEmailLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.technicianNameComboBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(technicianNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(technicianPhoneLabel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 476);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // TechnicianIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TechnicianIncidentsUserControl";
            this.Size = new System.Drawing.Size(533, 565);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource technicianBindingSource;
        private System.Windows.Forms.TextBox technicianEmailTextBox;
        private System.Windows.Forms.ComboBox technicianNameComboBox;
        private System.Windows.Forms.TextBox technicianPhoneTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}