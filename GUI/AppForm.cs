using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
            tb_summonerName.Text = "kisharcos04";
            cb_region.Text = "eun1";
            ApiHelper.InitializeClient();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            playerStatsPanel.Hide();
            matchesPanel.Hide();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();

            settings.Show();
        }

        private async void bt_searchClick(object sender, EventArgs e)
        {
            try
            {
                var summoner = await ApiCalls.LoadSummonerByName(tb_summonerName.Text, cb_region.Text);
                playerStatsPanel.setLabelId(summoner.Id);
                playerStatsPanel.setLabelLevel(summoner.SummonerLevel.ToString());
                playerStatsPanel.setLabelName(tb_summonerName.Text);
                playerStatsPanel.setLabelRevisionDate(summoner.ModifiedDate.ToString("d", CultureInfo.InvariantCulture));
                matchesPanel.Hide();
                playerStatsPanel.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Summoner Cannot Be Found", "error", MessageBoxButtons.OK);
            }
            
        }

        private void tb_summonerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return)
            {
                bt_searchClick(sender,new EventArgs());
            }
        }

        private void form_App_Load(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);


            ApiHelper.DeveloperKey = File.ReadAllText($@"{directory}\apiKey.txt");
        }

        private void bt_matches_Click(object sender, EventArgs e)
        {
            playerStatsPanel.Hide();
            matchesPanel.Show();
        }

        private void bt_player_Click(object sender, EventArgs e)
        {
            playerStatsPanel.Show();
            matchesPanel.Hide();
        }
    }
}
