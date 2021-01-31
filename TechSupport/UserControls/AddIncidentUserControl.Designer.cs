
namespace TechSupport.UserControls
{
    partial class AddIncidentUserControl
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.81132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.18868F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 328F));
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.customerIdLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.customerIDTextBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 317);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(30, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(100, 23);
            this.titleLabel.TabIndex = 100;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(30, 98);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 23);
            this.descriptionLabel.TabIndex = 101;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdLabel.Location = new System.Drawing.Point(30, 148);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(100, 23);
            this.customerIdLabel.TabIndex = 102;
            this.customerIdLabel.Text = "CustomerID:";
            this.customerIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(140, 53);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(214, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(140, 101);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(214, 20);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(140, 151);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(214, 20);
            this.customerIDTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(30, 210);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 70);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(140, 210);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 70);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddIncidentUserControl";
            this.Size = new System.Drawing.Size(472, 323);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
