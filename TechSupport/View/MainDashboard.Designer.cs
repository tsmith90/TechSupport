
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
            this.openIncidentsTabPage.SuspendLayout();
            this.searchIncidentTabPage.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.dashboardTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // openIncidentsTabPage
            // 
            this.openIncidentsTabPage.Controls.Add(this.openIncidentsUserControl1);
            this.openIncidentsTabPage.Location = new System.Drawing.Point(4, 25);
            this.openIncidentsTabPage.Name = "openIncidentsTabPage";
            this.openIncidentsTabPage.Size = new System.Drawing.Size(617, 384);
            this.openIncidentsTabPage.TabIndex = 3;
            this.openIncidentsTabPage.Text = "Display Open Incidents";
            this.openIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // openIncidentsUserControl1
            // 
            this.openIncidentsUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openIncidentsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.openIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.openIncidentsUserControl1.Name = "openIncidentsUserControl1";
            this.openIncidentsUserControl1.Size = new System.Drawing.Size(617, 327);
            this.openIncidentsUserControl1.TabIndex = 0;
            // 
            // searchIncidentTabPage
            // 
            this.searchIncidentTabPage.Controls.Add(this.searchIncidentUserControl1);
            this.searchIncidentTabPage.Location = new System.Drawing.Point(4, 25);
            this.searchIncidentTabPage.Name = "searchIncidentTabPage";
            this.searchIncidentTabPage.Size = new System.Drawing.Size(617, 384);
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
            this.addIncidentTabPage.Size = new System.Drawing.Size(617, 384);
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
            this.dashboardTabControl.Location = new System.Drawing.Point(0, 2);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 0;
            this.dashboardTabControl.Size = new System.Drawing.Size(625, 413);
            this.dashboardTabControl.TabIndex = 3;
            this.dashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.Dashboard_SelectedIndexChanged);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 415);
            this.Controls.Add(this.dashboardTabControl);
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
    }
}