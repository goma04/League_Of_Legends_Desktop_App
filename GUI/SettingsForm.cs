using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_GUI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            currentKey.SetToolTip(pb_info,ApiHelper.DeveloperKey);
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            ApiHelper.DeveloperKey = tb_key.Text;
            FileHandler.saveToTxt(tb_key.Text,"apiKey.txt");
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
