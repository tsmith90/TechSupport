
using TechSupport.Controller;

namespace TechSupport.View
{
    partial class MainDashboard
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
            this.openIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.updateIncidentTabPage = new System.Windows.Forms.TabPage();
            this.addIncidentTabPage = new System.Windows.Forms.TabPage();
            this.technicianTabControl = new System.Windows.Forms.TabControl();
            this.technicianTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.openIncidentsUserControl1 = new TechSupport.UserControls.OpenIncidentsUserControl();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.updateIncidentUserControl1 = new TechSupport.UserControls.UpdateIncidentUserControl();
            this.technicianIncidentsUserControl1 = new TechSupport.UserControls.TechnicianIncidentsUserControl();
            this.reportUserControl1 = new TechSupport.UserControls.ReportUserControl();
            this.openIncidentsTabPage.SuspendLayout();
            this.updateIncidentTabPage.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.technicianTabControl.SuspendLayout();
            this.technicianTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.reportTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // openIncidentsTabPage
            // 
            this.openIncidentsTabPage.Controls.Add(this.openIncidentsUserControl1);
            this.openIncidentsTabPage.Location = new System.Drawing.Point(4, 25);
            this.openIncidentsTabPage.Name = "openIncidentsTabPage";
            this.openIncidentsTabPage.Size = new System.Drawing.Size(707, 616);
            this.openIncidentsTabPage.TabIndex = 3;
            this.openIncidentsTabPage.Text = "Display Open Incidents";
            this.openIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // updateIncidentTabPage
            // 
            this.updateIncidentTabPage.Controls.Add(this.updateIncidentUserControl1);
            this.updateIncidentTabPage.Location = new System.Drawing.Point(4, 25);
            this.updateIncidentTabPage.Name = "updateIncidentTabPage";
            this.updateIncidentTabPage.Size = new System.Drawing.Size(707, 616);
            this.updateIncidentTabPage.TabIndex = 2;
            this.updateIncidentTabPage.Text = "Update";
            this.updateIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 25);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(707, 616);
            this.addIncidentTabPage.TabIndex = 1;
            this.addIncidentTabPage.Text = "Add";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // technicianTabControl
            // 
            this.technicianTabControl.Controls.Add(this.openIncidentsTabPage);
            this.technicianTabControl.Controls.Add(this.addIncidentTabPage);
            this.technicianTabControl.Controls.Add(this.updateIncidentTabPage);
            this.technicianTabControl.Controls.Add(this.technicianTabPage);
            this.technicianTabControl.Controls.Add(this.reportTabPage);
            this.technicianTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.technicianTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianTabControl.Location = new System.Drawing.Point(0, 41);
            this.technicianTabControl.Name = "technicianTabControl";
            this.technicianTabControl.SelectedIndex = 0;
            this.technicianTabControl.Size = new System.Drawing.Size(715, 645);
            this.technicianTabControl.TabIndex = 3;
            this.technicianTabControl.SelectedIndexChanged += new System.EventHandler(this.Dashboard_SelectedIndexChanged);
            // 
            // technicianTabPage
            // 
            this.technicianTabPage.Controls.Add(this.technicianIncidentsUserControl1);
            this.technicianTabPage.Location = new System.Drawing.Point(4, 25);
            this.technicianTabPage.Name = "technicianTabPage";
            this.technicianTabPage.Size = new System.Drawing.Size(707, 616);
            this.technicianTabPage.TabIndex = 0;
            this.technicianTabPage.Text = "View Incidents by Technician";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.52026F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.47974F));
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.logoutLink, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.92308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.07692F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 57);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(532, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(74, 32);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutLink
            // 
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.Location = new System.Drawing.Point(612, 0);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(69, 32);
            this.logoutLink.TabIndex = 1;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // reportTabPage
            // 
            this.reportTabPage.Controls.Add(this.reportUserControl1);
            this.reportTabPage.Location = new System.Drawing.Point(4, 25);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Size = new System.Drawing.Size(707, 616);
            this.reportTabPage.TabIndex = 4;
            this.reportTabPage.Text = "Report";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // openIncidentsUserControl1
            // 
            this.openIncidentsUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openIncidentsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.openIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.openIncidentsUserControl1.Name = "openIncidentsUserControl1";
            this.openIncidentsUserControl1.Size = new System.Drawing.Size(711, 603);
            this.openIncidentsUserControl1.TabIndex = 0;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentUserControl1.Location = new System.Drawing.Point(38, 77);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(632, 384);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // updateIncidentUserControl1
            // 
            this.updateIncidentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateIncidentUserControl1.Location = new System.Drawing.Point(33, 0);
            this.updateIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateIncidentUserControl1.Name = "updateIncidentUserControl1";
            this.updateIncidentUserControl1.Size = new System.Drawing.Size(636, 535);
            this.updateIncidentUserControl1.TabIndex = 0;
            // 
            // technicianIncidentsUserControl1
            // 
            this.technicianIncidentsUserControl1.Location = new System.Drawing.Point(0, 4);
            this.technicianIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.technicianIncidentsUserControl1.Name = "technicianIncidentsUserControl1";
            this.technicianIncidentsUserControl1.Size = new System.Drawing.Size(665, 539);
            this.technicianIncidentsUserControl1.TabIndex = 0;
            // 
            // reportUserControl1
            // 
            this.reportUserControl1.Location = new System.Drawing.Point(3, 4);
            this.reportUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportUserControl1.Name = "reportUserControl1";
            this.reportUserControl1.Size = new System.Drawing.Size(695, 587);
            this.reportUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 686);
            this.Controls.Add(this.technicianTabControl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabbed Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_SelectedIndexChanged);
            this.openIncidentsTabPage.ResumeLayout(false);
            this.updateIncidentTabPage.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.technicianTabControl.ResumeLayout(false);
            this.technicianTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.reportTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage openIncidentsTabPage;
        private System.Windows.Forms.TabPage updateIncidentTabPage;
        private UserControls.UpdateIncidentUserControl updateIncidentUserControl1;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
        private System.Windows.Forms.TabControl technicianTabControl;
        private UserControls.OpenIncidentsUserControl openIncidentsUserControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.TabPage technicianTabPage;
        private UserControls.TechnicianIncidentsUserControl technicianIncidentsUserControl1;
        private System.Windows.Forms.TabPage reportTabPage;
        private UserControls.ReportUserControl reportUserControl1;
    }
}