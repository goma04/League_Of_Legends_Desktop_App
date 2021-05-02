
namespace API_GUI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tb_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.bt_save = new System.Windows.Forms.Button();
            this.currentKey = new System.Windows.Forms.ToolTip(this.components);
            this.pb_info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(263, 35);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(319, 22);
            this.tb_key.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Developer API Key:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel9.Location = new System.Drawing.Point(438, 92);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(23, 56);
            this.panel9.TabIndex = 12;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.MediumPurple;
            this.bt_save.FlatAppearance.BorderSize = 0;
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Location = new System.Drawing.Point(460, 92);
            this.bt_save.Margin = new System.Windows.Forms.Padding(4);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(106, 56);
            this.bt_save.TabIndex = 11;
            this.bt_save.Text = "Save";
            this.bt_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // pb_info
            // 
            this.pb_info.Image = ((System.Drawing.Image)(resources.GetObject("pb_info.Image")));
            this.pb_info.Location = new System.Drawing.Point(16, 117);
            this.pb_info.Name = "pb_info";
            this.pb_info.Size = new System.Drawing.Size(43, 45);
            this.pb_info.TabIndex = 13;
            this.pb_info.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 174);
            this.Controls.Add(this.pb_info);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_key);
            this.Name = "SettingsForm";
            this.Text = "settings";
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.ToolTip currentKey;
        private System.Windows.Forms.PictureBox pb_info;
    }
}