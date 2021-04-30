using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_GUI.Control;
using API_GUI.League;

namespace API_GUI
{
    public partial class form_App : Form
    {
        public form_App()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            playerStatPanel.Hide();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();

            settings.Show();
        }

        private async void bt_searchClick(object sender, EventArgs e)
        {
            playerStatPanel.Show();
            l_summonerNameTitle.Text = tb_summonerName.Text;
            var summoner = await LolApiCall.LoadSummonerByName(tb_summonerName.Text);

            l_id.Text = summoner.Id;
            l_level.Text = summoner.SummonerLevel.ToString();
        }

        private void tb_summonerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return)
            {
                bt_searchClick(sender,new EventArgs());
            }
        }
    }
}
