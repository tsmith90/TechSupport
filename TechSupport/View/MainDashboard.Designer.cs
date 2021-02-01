
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
            this.dashboardTabControl = new System.Windows.Forms.TabControl();
            this.addIncidentTabPage = new System.Windows.Forms.TabPage();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.allIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.mainFormUserControl1 = new TechSupport.UserControls.AllIncidentsUserControl();
            this.searchIncidentTabPage = new System.Windows.Forms.TabPage();
            this.searchIncidentUserControl1 = new TechSupport.UserControls.SearchIncidentUserControl();
            this.dashboardTabControl.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.allIncidentsTabPage.SuspendLayout();
            this.searchIncidentTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardTabControl
            // 
            this.dashboardTabControl.Controls.Add(this.addIncidentTabPage);
            this.dashboardTabControl.Controls.Add(this.allIncidentsTabPage);
            this.dashboardTabControl.Controls.Add(this.searchIncidentTabPage);
            this.dashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardTabControl.Location = new System.Drawing.Point(0, 2);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 0;
            this.dashboardTabControl.Size = new System.Drawing.Size(484, 359);
            this.dashboardTabControl.TabIndex = 3;
            this.dashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(476, 326);
            this.addIncidentTabPage.TabIndex = 1;
            this.addIncidentTabPage.Text = "Add Incident";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(472, 323);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // allIncidentsTabPage
            // 
            this.allIncidentsTabPage.Controls.Add(this.mainFormUserControl1);
            this.allIncidentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.allIncidentsTabPage.Name = "allIncidentsTabPage";
            this.allIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allIncidentsTabPage.Size = new System.Drawing.Size(476, 326);
            this.allIncidentsTabPage.TabIndex = 0;
            this.allIncidentsTabPage.Text = "All Incidents";
            this.allIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // mainFormUserControl1
            // 
            this.mainFormUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormUserControl1.Location = new System.Drawing.Point(0, 0);
            this.mainFormUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainFormUserControl1.Name = "mainFormUserControl1";
            this.mainFormUserControl1.Size = new System.Drawing.Size(476, 328);
            this.mainFormUserControl1.TabIndex = 0;
            // 
            // searchIncidentTabPage
            // 
            this.searchIncidentTabPage.Controls.Add(this.searchIncidentUserControl1);
            this.searchIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.searchIncidentTabPage.Name = "searchIncidentTabPage";
            this.searchIncidentTabPage.Size = new System.Drawing.Size(476, 326);
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
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.dashboardTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabbed Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashBoard_FormClosed);
            this.dashboardTabControl.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.allIncidentsTabPage.ResumeLayout(false);
            this.searchIncidentTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dashboardTabControl;
        private System.Windows.Forms.TabPage allIncidentsTabPage;
        private System.Windows.Forms.TabPage searchIncidentTabPage;
        private UserControls.AllIncidentsUserControl mainFormUserControl1;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private UserControls.SearchIncidentUserControl searchIncidentUserControl1;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
    }
}