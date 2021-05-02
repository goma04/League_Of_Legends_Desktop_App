
using API_GUI.GUI;

namespace API_GUI
{
    partial class form_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_App));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_matches = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_player = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_search = new System.Windows.Forms.Panel();
            this.cb_region = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_summonerName = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.bt_search = new System.Windows.Forms.Button();
            this.playerStatsPanel = new API_GUI.GUI.PlayerSummaryPanel();
            this.matchesPanel = new API_GUI.GUI.MatchesPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.bt_matches);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bt_player);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 579);
            this.panel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel10.Location = new System.Drawing.Point(-2, 386);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(16, 76);
            this.panel10.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 391);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 68);
            this.button6.TabIndex = 8;
            this.button6.Text = "    Settings";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel7.Location = new System.Drawing.Point(-1, 265);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(16, 76);
            this.panel7.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel6.Location = new System.Drawing.Point(-1, 180);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 76);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Brown;
            this.panel5.Location = new System.Drawing.Point(0, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 76);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel4.Location = new System.Drawing.Point(-2, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(16, 76);
            this.panel4.TabIndex = 3;
            // 
            // bt_matches
            // 
            this.bt_matches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_matches.FlatAppearance.BorderSize = 0;
            this.bt_matches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_matches.ForeColor = System.Drawing.Color.White;
            this.bt_matches.Image = ((System.Drawing.Image)(resources.GetObject("bt_matches.Image")));
            this.bt_matches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_matches.Location = new System.Drawing.Point(15, 95);
            this.bt_matches.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.bt_matches.Name = "bt_matches";
            this.bt_matches.Size = new System.Drawing.Size(186, 76);
            this.bt_matches.TabIndex = 6;
            this.bt_matches.Text = "     Matches";
            this.bt_matches.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_matches.UseVisualStyleBackColor = true;
            this.bt_matches.Click += new System.EventHandler(this.bt_matches_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(15, 180);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 76);
            this.button3.TabIndex = 5;
            this.button3.Text = "     Live ";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 265);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 76);
            this.button2.TabIndex = 4;
            this.button2.Text = "    Champions";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_player
            // 
            this.bt_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_player.FlatAppearance.BorderSize = 0;
            this.bt_player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_player.ForeColor = System.Drawing.Color.White;
            this.bt_player.Image = ((System.Drawing.Image)(resources.GetObject("bt_player.Image")));
            this.bt_player.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_player.Location = new System.Drawing.Point(15, 11);
            this.bt_player.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.bt_player.Name = "bt_player";
            this.bt_player.Size = new System.Drawing.Size(186, 76);
            this.bt_player.TabIndex = 3;
            this.bt_player.Text = "    Player       Statistics";
            this.bt_player.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_player.UseVisualStyleBackColor = true;
            this.bt_player.Click += new System.EventHandler(this.bt_player_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(207, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 27);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(994, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(106, 129);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "~By Goma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Stats";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // p_search
            // 
            this.p_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_search.Controls.Add(this.cb_region);
            this.p_search.Controls.Add(this.label4);
            this.p_search.Controls.Add(this.tb_summonerName);
            this.p_search.Controls.Add(this.panel9);
            this.p_search.Controls.Add(this.bt_search);
            this.p_search.Location = new System.Drawing.Point(220, 28);
            this.p_search.Name = "p_search";
            this.p_search.Size = new System.Drawing.Size(583, 137);
            this.p_search.TabIndex = 4;
            // 
            // cb_region
            // 
            this.cb_region.FormattingEnabled = true;
            this.cb_region.Items.AddRange(new object[] {
            "eun1",
            "br1",
            "kr",
            "jp1"});
            this.cb_region.Location = new System.Drawing.Point(438, 27);
            this.cb_region.Name = "cb_region";
            this.cb_region.Size = new System.Drawing.Size(121, 35);
            this.cb_region.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(38, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Summoner:";
            // 
            // tb_summonerName
            // 
            this.tb_summonerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_summonerName.Location = new System.Drawing.Point(191, 27);
            this.tb_summonerName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_summonerName.Name = "tb_summonerName";
            this.tb_summonerName.Size = new System.Drawing.Size(207, 36);
            this.tb_summonerName.TabIndex = 8;
            this.tb_summonerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_summonerName_KeyPress);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel9.Location = new System.Drawing.Point(215, 69);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(25, 55);
            this.panel9.TabIndex = 10;
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.MediumPurple;
            this.bt_search.FlatAppearance.BorderSize = 0;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Image = ((System.Drawing.Image)(resources.GetObject("bt_search.Image")));
            this.bt_search.Location = new System.Drawing.Point(237, 69);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(161, 55);
            this.bt_search.TabIndex = 9;
            this.bt_search.Text = "Search";
            this.bt_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_searchClick);
            // 
            // playerStatsPanel
            // 
            this.playerStatsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.playerStatsPanel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerStatsPanel.Location = new System.Drawing.Point(220, 172);
            this.playerStatsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.playerStatsPanel.Name = "playerStatsPanel";
            this.playerStatsPanel.Size = new System.Drawing.Size(880, 400);
            this.playerStatsPanel.TabIndex = 5;
            // 
            // matchesPanel
            // 
            this.matchesPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.matchesPanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchesPanel.Location = new System.Drawing.Point(220, 172);
            this.matchesPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.matchesPanel.Name = "matchesPanel";
            this.matchesPanel.Size = new System.Drawing.Size(880, 400);
            this.matchesPanel.TabIndex = 6;
            // 
            // form_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 579);
            this.Controls.Add(this.matchesPanel);
            this.Controls.Add(this.playerStatsPanel);
            this.Controls.Add(this.p_search);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "form_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_App_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p_search.ResumeLayout(false);
            this.p_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_matches;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_player;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel p_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_summonerName;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cb_region;
        private PlayerSummaryPanel playerStatsPanel;
        private MatchesPanel matchesPanel;
    }
}

