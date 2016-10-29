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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private player myPlayer;
        private map myMap;
        public Form1()
        {
            InitializeComponent();

            timer_refresh.Start();
            timer_refresh.Interval = 100;

            this.myPlayer = new player();
            this.myMap = new map();
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            myPlayer.cherchePlayerInfo();
            myMap.chercheMapInfo();

            l_nickname.Text = "Player: " + myPlayer.NICKNAME1;

            l_hp.Text = Convert.ToString(myPlayer.HP1) + " / " + Convert.ToString(myPlayer.HP_MAX1);
            l_mp.Text = Convert.ToString(myPlayer.MP1) + " / " + Convert.ToString(myPlayer.MP_MAX1);

            l_gold.Text = "Gold: " + Convert.ToString(myPlayer.GOLD1);

            pb_hp.Value = ((int)myPlayer.HP1 * 100) / (int)myPlayer.HP_MAX1;
            pb_mp.Value = ((int)myPlayer.MP1 * 100) / (int)myPlayer.MP_MAX1;

            l_lvl.Text = "Level: " + Convert.ToString(myPlayer.PLAYER_LVL1);
            l_jlvl.Text = "JLevel: " + Convert.ToString(myPlayer.PLAYER_JLVL1);
            if (myPlayer.PLAYER_TARGET_NAME1.Length != 0)
            {
                l_target.Text = myPlayer.PLAYER_TARGET_NAME1;
            }
            if (myPlayer.PLAYER_TARGET_NAME1.Length == 0)
            {
                l_target.Text = myPlayer.NPC_TARGET_NAME1;
            }

            l_mapId.Text = "Map: " + Convert.ToString(myMap.MAP_ID1);
            l_aitem.Text = "Items: " + Convert.ToString(myMap.ITEM_AMOUNT1);
            l_amob.Text = "Mobs: " + Convert.ToString(myMap.MOB_AMOUNT1);
            l_anpc.Text = "NPCs:" + Convert.ToString(myMap.NPC_AMOUNT1);
            l_aplayer.Text = "Players: " + Convert.ToString(myMap.PLAYER_AMOUNT1);

        }
    }
}
