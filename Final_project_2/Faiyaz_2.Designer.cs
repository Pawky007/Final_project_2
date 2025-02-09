namespace Final_project_2
{
    partial class Faiyaz_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faiyaz_2));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnDashboard = new System.Windows.Forms.Button();
            this.pnBuyTicket = new System.Windows.Forms.Button();
            this.pnViewHistory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pnTopUp = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.pnBuyTicket);
            this.sidebar.Controls.Add(this.pnTopUp);
            this.sidebar.Controls.Add(this.pnViewHistory);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.sidebar.Location = new System.Drawing.Point(0, 41);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(275, 620);
            this.sidebar.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnDashboard);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 89);
            this.panel2.TabIndex = 3;
            // 
            // pnDashboard
            // 
            this.pnDashboard.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pnDashboard.Image")));
            this.pnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnDashboard.Location = new System.Drawing.Point(0, 6);
            this.pnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(287, 82);
            this.pnDashboard.TabIndex = 2;
            this.pnDashboard.Text = "Dashboard";
            this.pnDashboard.UseVisualStyleBackColor = true;
            this.pnDashboard.Click += new System.EventHandler(this.pnDashboard_Click);
            // 
            // pnBuyTicket
            // 
            this.pnBuyTicket.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnBuyTicket.Image = ((System.Drawing.Image)(resources.GetObject("pnBuyTicket.Image")));
            this.pnBuyTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnBuyTicket.Location = new System.Drawing.Point(2, 95);
            this.pnBuyTicket.Margin = new System.Windows.Forms.Padding(2);
            this.pnBuyTicket.Name = "pnBuyTicket";
            this.pnBuyTicket.Size = new System.Drawing.Size(275, 82);
            this.pnBuyTicket.TabIndex = 4;
            this.pnBuyTicket.Text = "Buy Ticket";
            this.pnBuyTicket.UseVisualStyleBackColor = true;
            this.pnBuyTicket.Click += new System.EventHandler(this.pnBuyTicket_Click);
            // 
            // pnViewHistory
            // 
            this.pnViewHistory.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnViewHistory.Image = ((System.Drawing.Image)(resources.GetObject("pnViewHistory.Image")));
            this.pnViewHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnViewHistory.Location = new System.Drawing.Point(2, 256);
            this.pnViewHistory.Margin = new System.Windows.Forms.Padding(2);
            this.pnViewHistory.Name = "pnViewHistory";
            this.pnViewHistory.Size = new System.Drawing.Size(273, 71);
            this.pnViewHistory.TabIndex = 6;
            this.pnViewHistory.Text = "View History";
            this.pnViewHistory.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(2, 331);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(273, 71);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 41);
            this.panel1.TabIndex = 2;
            // 
            // menuButton
            // 
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(2, 4);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(50, 34);
            this.menuButton.TabIndex = 2;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(2, 38);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 102);
            this.button5.TabIndex = 7;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // pnTopUp
            // 
            this.pnTopUp.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTopUp.Image = ((System.Drawing.Image)(resources.GetObject("pnTopUp.Image")));
            this.pnTopUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnTopUp.Location = new System.Drawing.Point(2, 181);
            this.pnTopUp.Margin = new System.Windows.Forms.Padding(2);
            this.pnTopUp.Name = "pnTopUp";
            this.pnTopUp.Size = new System.Drawing.Size(273, 71);
            this.pnTopUp.TabIndex = 5;
            this.pnTopUp.Text = "Top Up";
            this.pnTopUp.UseVisualStyleBackColor = true;
            this.pnTopUp.Click += new System.EventHandler(this.pnTopUp_Click);
            // 
            // Faiyaz_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 661);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Name = "Faiyaz_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faiyaz_2";
            this.Load += new System.EventHandler(this.Faiyaz_2_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button pnDashboard;
        private System.Windows.Forms.Button pnBuyTicket;
        private System.Windows.Forms.Button pnViewHistory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button pnTopUp;
    }
}