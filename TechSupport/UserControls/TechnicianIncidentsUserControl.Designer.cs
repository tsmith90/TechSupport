

namespace TechSupport.UserControls
{
    partial class technicianIncidentsUserControl
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
            technicianEmailLabel = new System.Windows.Forms.Label();
            technicianNameLabel = new System.Windows.Forms.Label();
            technicianPhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // technicianEmailLabel
            // 
            technicianEmailLabel.AutoSize = true;
            technicianEmailLabel.Location = new System.Drawing.Point(66, 125);
            technicianEmailLabel.Name = "technicianEmailLabel";
            technicianEmailLabel.Size = new System.Drawing.Size(91, 13);
            technicianEmailLabel.TabIndex = 1;
            technicianEmailLabel.Text = "Technician Email:";
            // 
            // technicianNameLabel
            // 
            technicianNameLabel.AutoSize = true;
            technicianNameLabel.Location = new System.Drawing.Point(66, 54);
            technicianNameLabel.Name = "technicianNameLabel";
            technicianNameLabel.Size = new System.Drawing.Size(94, 13);
            technicianNameLabel.TabIndex = 5;
            technicianNameLabel.Text = "Technician Name:";
            // 
            // technicianPhoneLabel
            // 
            technicianPhoneLabel.AutoSize = true;
            technicianPhoneLabel.Location = new System.Drawing.Point(63, 199);
            technicianPhoneLabel.Name = "technicianPhoneLabel";
            technicianPhoneLabel.Size = new System.Drawing.Size(97, 13);
            technicianPhoneLabel.TabIndex = 7;
            technicianPhoneLabel.Text = "Technician Phone:";
            // 
            // technicianEmailTextBox
            // 
            this.technicianEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "TechnicianEmail", true));
            this.technicianEmailTextBox.Location = new System.Drawing.Point(169, 125);
            this.technicianEmailTextBox.Name = "technicianEmailTextBox";
            this.technicianEmailTextBox.ReadOnly = true;
            this.technicianEmailTextBox.Size = new System.Drawing.Size(121, 20);
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
            this.technicianNameComboBox.Location = new System.Drawing.Point(169, 54);
            this.technicianNameComboBox.Name = "technicianNameComboBox";
            this.technicianNameComboBox.Size = new System.Drawing.Size(210, 21);
            this.technicianNameComboBox.TabIndex = 6;
            this.technicianNameComboBox.ValueMember = "TechnicianName";
            this.technicianNameComboBox.SelectedIndexChanged += new System.EventHandler(this.technicianNameComboBox_SelectedIndexChanged);
            // 
            // technicianPhoneTextBox
            // 
            this.technicianPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "TechnicianPhone", true));
            this.technicianPhoneTextBox.Location = new System.Drawing.Point(166, 196);
            this.technicianPhoneTextBox.Name = "technicianPhoneTextBox";
            this.technicianPhoneTextBox.ReadOnly = true;
            this.technicianPhoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.technicianPhoneTextBox.TabIndex = 8;
            // 
            // technicianIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(technicianEmailLabel);
            this.Controls.Add(this.technicianEmailTextBox);
            this.Controls.Add(technicianNameLabel);
            this.Controls.Add(this.technicianNameComboBox);
            this.Controls.Add(technicianPhoneLabel);
            this.Controls.Add(this.technicianPhoneTextBox);
            this.Name = "technicianIncidentsUserControl";
            this.Size = new System.Drawing.Size(533, 565);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource technicianBindingSource;
        private System.Windows.Forms.TextBox technicianEmailTextBox;
        private System.Windows.Forms.ComboBox technicianNameComboBox;
        private System.Windows.Forms.TextBox technicianPhoneTextBox;
    }
}