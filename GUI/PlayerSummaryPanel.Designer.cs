
using System.Reflection.Emit;
using System.Windows.Forms;

namespace API_GUI.GUI
{
    partial class PlayerSummaryPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_revisionDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_level = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_summonerNameTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.l_revisionDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.l_level);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.l_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.l_summonerNameTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 480);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(291, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(57, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 37);
            this.label7.TabIndex = 26;
            this.label7.Text = "Last Modified:";
            // 
            // l_revisionDate
            // 
            this.l_revisionDate.AutoSize = true;
            this.l_revisionDate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_revisionDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_revisionDate.Location = new System.Drawing.Point(279, 241);
            this.l_revisionDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_revisionDate.Name = "l_revisionDate";
            this.l_revisionDate.Size = new System.Drawing.Size(0, 37);
            this.l_revisionDate.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(179, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = "Level:";
            // 
            // l_level
            // 
            this.l_level.AutoSize = true;
            this.l_level.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_level.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_level.Location = new System.Drawing.Point(291, 169);
            this.l_level.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_level.Name = "l_level";
            this.l_level.Size = new System.Drawing.Size(0, 37);
            this.l_level.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(225, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "Id:";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_id.Location = new System.Drawing.Point(270, 109);
            this.l_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(45, 37);
            this.l_id.TabIndex = 21;
            this.l_id.Text = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(165, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "Name:";
            // 
            // l_summonerNameTitle
            // 
            this.l_summonerNameTitle.AutoSize = true;
            this.l_summonerNameTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_summonerNameTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_summonerNameTitle.Location = new System.Drawing.Point(291, 52);
            this.l_summonerNameTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_summonerNameTitle.Name = "l_summonerNameTitle";
            this.l_summonerNameTitle.Size = new System.Drawing.Size(0, 37);
            this.l_summonerNameTitle.TabIndex = 19;
            // 
            // PlayerSummaryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PlayerSummaryPanel";
            this.Size = new System.Drawing.Size(884, 480);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_revisionDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_level;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_summonerNameTitle;
        private System.Windows.Forms.Label label2;

        public System.Windows.Forms.Label L_RevisionDate { get; set; } = new System.Windows.Forms.Label();
        public System.Windows.Forms.Label L_Id { get; set; } = new System.Windows.Forms.Label();
        public System.Windows.Forms.Label L_Level { get; set; } = new System.Windows.Forms.Label();
        public System.Windows.Forms.Label L_SummonerName { get; set; } = new System.Windows.Forms.Label();
    }
}
