using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_GUI.GUI
{
    public partial class PlayerSummaryPanel : UserControl
    {
        public PlayerSummaryPanel()
        {
            InitializeComponent();
        }

        public void setLabelName(string text)
        {
            l_summonerName.Text = text;
        }

        public void setLabelRevisionDate(string text)
        {
            l_revisionDate.Text = text;
        }

        public void setLabelId(string text)
        {
            l_id.Text = text;
        }

        public void setLabelLevel(string text)
        {
            l_level.Text = text;
        }
    }
}
