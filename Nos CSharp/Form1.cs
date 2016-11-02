using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Nos_CSharp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private player myPlayer;
        private map myMap;

        public void form_pos()
        {
            string postohex = string.Format("{0:X}", myPlayer.POSITION1);
            string x = postohex.Substring(4);
            string y = postohex.Substring(0, 2);
            int x_todec = Int32.Parse(x, System.Globalization.NumberStyles.HexNumber);
            int y_todec = Int32.Parse(y, System.Globalization.NumberStyles.HexNumber);
            l_pos.Text = x_todec + " | " + y_todec;
        }
        public Form1()
        {
            InitializeComponent();

            timer_refresh.Start();
            timer_refresh.Interval = 100;

            pb_exp.Minimum = 0;

            this.myPlayer = new player();
            this.myMap = new map();
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            myPlayer.cherchePlayerInfo();
            myMap.chercheMapInfo();

            #region player infos
            l_nickname.Text = "Player: " + myPlayer.NICKNAME1;

            l_hp.Text = Convert.ToString(myPlayer.HP1) + " / " + Convert.ToString(myPlayer.HP_MAX1);
            l_mp.Text = Convert.ToString(myPlayer.MP1) + " / " + Convert.ToString(myPlayer.MP_MAX1);
            l_gold.Text = "Gold: " + Convert.ToString(myPlayer.GOLD1);

            pb_hp.Value = ((int)myPlayer.HP1 * 100) / (int)myPlayer.HP_MAX1;
            pb_mp.Value = ((int)myPlayer.MP1 * 100) / (int)myPlayer.MP_MAX1;
            pb_exp.Value = (int)myPlayer.EXP1;

            l_lvl.Text = "Level: " + Convert.ToString(myPlayer.PLAYER_LVL1);
            l_jlvl.Text = "JLevel: " + Convert.ToString(myPlayer.PLAYER_JLVL1);
            #endregion

            #region map infos
            l_mapId.Text = "Map: " + Convert.ToString(myMap.MAP_ID1);
            l_aitem.Text = "Items: " + Convert.ToString(myMap.ITEM_AMOUNT1);
            l_amob.Text = "Mobs: " + Convert.ToString(myMap.MOB_AMOUNT1);
            l_anpc.Text = "NPCs: " + Convert.ToString(myMap.NPC_AMOUNT1);
            l_aplayer.Text = "Players: " + Convert.ToString(myMap.PLAYER_AMOUNT1);
            form_pos();
            #endregion
        }
    }
}
