using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nos_CSharp
{
    public partial class liste : Form
    {
        private player _myPlayer;
        private map _myMap;

        public liste(Form1 myForm, player myPlayer, map myMap)
        {       
            InitializeComponent();

            timer_refresh_liste.Start();
            timer_refresh_liste.Interval = 2000;

            this._myPlayer = myPlayer;
            this._myMap = myMap;

            lv_player.Columns.Add("Nickname");
        }

        private void liste_Load(object sender, EventArgs e)
        {
            List<string> namePlayer = _myMap.playerListe();
            foreach (string name in namePlayer)
            {
                string[] data_name = {name};

                var listViewItem = new ListViewItem(data_name);

                lv_player.Items.Add(listViewItem);
                lv_player.Sort();
            }
        }

        private void timer_refresh_liste_Tick(object sender, EventArgs e)
        {

        }
    }
}
