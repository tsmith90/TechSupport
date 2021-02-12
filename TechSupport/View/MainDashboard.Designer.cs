
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
            this.openIncidentsUserControl1 = new TechSupport.UserControls.OpenIncidentsUserControl();
            this.searchIncidentTabPage = new System.Windows.Forms.TabPage();
            this.searchIncidentUserControl1 = new TechSupport.UserControls.SearchIncidentUserControl();
            this.addIncidentTabPage = new System.Windows.Forms.TabPage();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.dashboardTabControl = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.openIncidentsTabPage.SuspendLayout();
            this.searchIncidentTabPage.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.dashboardTabControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openIncidentsTabPage
            // 
            this.openIncidentsTabPage.Controls.Add(this.openIncidentsUserControl1);
            this.openIncidentsTabPage.Location = new System.Drawing.Point(4, 25);
            this.openIncidentsTabPage.Name = "openIncidentsTabPage";
            this.openIncidentsTabPage.Size = new System.Drawing.Size(632, 368);
            this.openIncidentsTabPage.TabIndex = 3;
            this.openIncidentsTabPage.Text = "Display Open Incidents";
            this.openIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // openIncidentsUserControl1
            // 
            this.openIncidentsUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openIncidentsUserControl1.Location = new System.Drawing.Point(0, 4);
            this.openIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.openIncidentsUserControl1.Name = "openIncidentsUserControl1";
            this.openIncidentsUserControl1.Size = new System.Drawing.Size(628, 360);
            this.openIncidentsUserControl1.TabIndex = 0;
            // 
            // searchIncidentTabPage
            // 
            this.searchIncidentTabPage.Controls.Add(this.searchIncidentUserControl1);
            this.searchIncidentTabPage.Location = new System.Drawing.Point(4, 25);
            this.searchIncidentTabPage.Name = "searchIncidentTabPage";
            this.searchIncidentTabPage.Size = new System.Drawing.Size(632, 358);
            this.searchIncidentTabPage.TabIndex = 2;
            this.searchIncidentTabPage.Text = "Search Incident";
            this.searchIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // searchIncidentUserControl1
            // 
            this.searchIncidentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIncidentUserControl1.Location = new System.Drawing.Point(-4, 0);
            this.searchIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchIncidentUserControl1.Name = "searchIncidentUserControl1";
            this.searchIncidentUserControl1.Size = new System.Drawing.Size(484, 328);
            this.searchIncidentUserControl1.TabIndex = 0;
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 25);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(632, 358);
            this.addIncidentTabPage.TabIndex = 1;
            this.addIncidentTabPage.Text = "Add";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(617, 384);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // dashboardTabControl
            // 
            this.dashboardTabControl.Controls.Add(this.openIncidentsTabPage);
            this.dashboardTabControl.Controls.Add(this.addIncidentTabPage);
            this.dashboardTabControl.Controls.Add(this.searchIncidentTabPage);
            this.dashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardTabControl.Location = new System.Drawing.Point(0, 30);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 0;
            this.dashboardTabControl.Size = new System.Drawing.Size(640, 397);
            this.dashboardTabControl.TabIndex = 3;
            this.dashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.Dashboard_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.52026F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.47974F));
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.logoutLink, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 409);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(462, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(74, 35);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutLink
            // 
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.Location = new System.Drawing.Point(542, 0);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(72, 35);
            this.logoutLink.TabIndex = 1;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 427);
            this.Controls.Add(this.dashboardTabControl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabbed Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_SelectedIndexChanged);
            this.openIncidentsTabPage.ResumeLayout(false);
            this.searchIncidentTabPage.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.dashboardTabControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage openIncidentsTabPage;
        private System.Windows.Forms.TabPage searchIncidentTabPage;
        private UserControls.SearchIncidentUserControl searchIncidentUserControl1;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
        private System.Windows.Forms.TabControl dashboardTabControl;
        private UserControls.OpenIncidentsUserControl openIncidentsUserControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel logoutLink;
    }
}