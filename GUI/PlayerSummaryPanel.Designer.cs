
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
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_revisionDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_level = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_summonerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(396, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(56, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Last Modified:";
            // 
            // l_revisionDate
            // 
            this.l_revisionDate.AutoSize = true;
            this.l_revisionDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_revisionDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_revisionDate.Location = new System.Drawing.Point(253, 199);
            this.l_revisionDate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.l_revisionDate.Name = "l_revisionDate";
            this.l_revisionDate.Size = new System.Drawing.Size(0, 22);
            this.l_revisionDate.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(127, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Level:";
            // 
            // l_level
            // 
            this.l_level.AutoSize = true;
            this.l_level.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_level.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_level.Location = new System.Drawing.Point(253, 154);
            this.l_level.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.l_level.Name = "l_level";
            this.l_level.Size = new System.Drawing.Size(0, 22);
            this.l_level.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(158, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Id:";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_id.Location = new System.Drawing.Point(253, 105);
            this.l_id.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(0, 22);
            this.l_id.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(120, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Name:";
            // 
            // l_summonerName
            // 
            this.l_summonerName.AutoSize = true;
            this.l_summonerName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_summonerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_summonerName.Location = new System.Drawing.Point(253, 58);
            this.l_summonerName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.l_summonerName.Name = "l_summonerName";
            this.l_summonerName.Size = new System.Drawing.Size(0, 22);
            this.l_summonerName.TabIndex = 19;
            // 
            // PlayerSummaryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.l_revisionDate);
            this.Controls.Add(this.l_level);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.l_summonerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlayerSummaryPanel";
            this.Size = new System.Drawing.Size(880, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_revisionDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_level;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_summonerName;
        private System.Windows.Forms.Label label2;


    }
}
