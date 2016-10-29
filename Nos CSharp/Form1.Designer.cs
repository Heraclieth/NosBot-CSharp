namespace Nos_CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_mp = new MetroFramework.Controls.MetroProgressBar();
            this.pb_hp = new MetroFramework.Controls.MetroProgressBar();
            this.l_nickname = new MetroFramework.Controls.MetroLabel();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.l_hp = new MetroFramework.Controls.MetroLabel();
            this.l_mp = new MetroFramework.Controls.MetroLabel();
            this.l_gold = new MetroFramework.Controls.MetroLabel();
            this.l_pos = new MetroFramework.Controls.MetroLabel();
            this.l_lvl = new MetroFramework.Controls.MetroLabel();
            this.l_jlvl = new MetroFramework.Controls.MetroLabel();
            this.l_target = new MetroFramework.Controls.MetroLabel();
            this.l_mapId = new MetroFramework.Controls.MetroLabel();
            this.l_aplayer = new MetroFramework.Controls.MetroLabel();
            this.l_anpc = new MetroFramework.Controls.MetroLabel();
            this.l_amob = new MetroFramework.Controls.MetroLabel();
            this.l_aitem = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // pb_mp
            // 
            this.pb_mp.Location = new System.Drawing.Point(92, 137);
            this.pb_mp.Name = "pb_mp";
            this.pb_mp.Size = new System.Drawing.Size(128, 23);
            this.pb_mp.Style = MetroFramework.MetroColorStyle.Yellow;
            this.pb_mp.TabIndex = 1;
            this.pb_mp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pb_hp
            // 
            this.pb_hp.Location = new System.Drawing.Point(92, 108);
            this.pb_hp.Name = "pb_hp";
            this.pb_hp.Size = new System.Drawing.Size(128, 23);
            this.pb_hp.Style = MetroFramework.MetroColorStyle.Yellow;
            this.pb_hp.TabIndex = 2;
            this.pb_hp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_nickname
            // 
            this.l_nickname.AutoSize = true;
            this.l_nickname.Location = new System.Drawing.Point(92, 86);
            this.l_nickname.Name = "l_nickname";
            this.l_nickname.Size = new System.Drawing.Size(52, 19);
            this.l_nickname.Style = MetroFramework.MetroColorStyle.Yellow;
            this.l_nickname.TabIndex = 3;
            this.l_nickname.Text = "pseudo";
            this.l_nickname.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer_refresh
            // 
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // l_hp
            // 
            this.l_hp.AutoSize = true;
            this.l_hp.Location = new System.Drawing.Point(12, 108);
            this.l_hp.Name = "l_hp";
            this.l_hp.Size = new System.Drawing.Size(26, 19);
            this.l_hp.Style = MetroFramework.MetroColorStyle.Yellow;
            this.l_hp.TabIndex = 4;
            this.l_hp.Text = "HP";
            this.l_hp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_mp
            // 
            this.l_mp.AutoSize = true;
            this.l_mp.Location = new System.Drawing.Point(12, 137);
            this.l_mp.Name = "l_mp";
            this.l_mp.Size = new System.Drawing.Size(29, 19);
            this.l_mp.Style = MetroFramework.MetroColorStyle.Yellow;
            this.l_mp.TabIndex = 5;
            this.l_mp.Text = "MP";
            this.l_mp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_gold
            // 
            this.l_gold.AutoSize = true;
            this.l_gold.Location = new System.Drawing.Point(12, 170);
            this.l_gold.Name = "l_gold";
            this.l_gold.Size = new System.Drawing.Size(44, 19);
            this.l_gold.Style = MetroFramework.MetroColorStyle.Yellow;
            this.l_gold.TabIndex = 6;
            this.l_gold.Text = "GOLD";
            this.l_gold.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_pos
            // 
            this.l_pos.AutoSize = true;
            this.l_pos.Location = new System.Drawing.Point(12, 352);
            this.l_pos.Name = "l_pos";
            this.l_pos.Size = new System.Drawing.Size(55, 19);
            this.l_pos.TabIndex = 7;
            this.l_pos.Text = "position";
            this.l_pos.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_lvl
            // 
            this.l_lvl.AutoSize = true;
            this.l_lvl.Location = new System.Drawing.Point(12, 204);
            this.l_lvl.Name = "l_lvl";
            this.l_lvl.Size = new System.Drawing.Size(43, 19);
            this.l_lvl.TabIndex = 8;
            this.l_lvl.Text = "LEVEL";
            this.l_lvl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_jlvl
            // 
            this.l_jlvl.AutoSize = true;
            this.l_jlvl.Location = new System.Drawing.Point(12, 238);
            this.l_jlvl.Name = "l_jlvl";
            this.l_jlvl.Size = new System.Drawing.Size(48, 19);
            this.l_jlvl.TabIndex = 9;
            this.l_jlvl.Text = "JLEVEL";
            this.l_jlvl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_target
            // 
            this.l_target.AutoSize = true;
            this.l_target.Location = new System.Drawing.Point(374, 63);
            this.l_target.Name = "l_target";
            this.l_target.Size = new System.Drawing.Size(92, 19);
            this.l_target.TabIndex = 10;
            this.l_target.Text = "TARGETNAME";
            this.l_target.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_mapId
            // 
            this.l_mapId.AutoSize = true;
            this.l_mapId.Location = new System.Drawing.Point(88, 352);
            this.l_mapId.Name = "l_mapId";
            this.l_mapId.Size = new System.Drawing.Size(56, 19);
            this.l_mapId.TabIndex = 11;
            this.l_mapId.Text = "MAP_ID";
            this.l_mapId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_aplayer
            // 
            this.l_aplayer.AutoSize = true;
            this.l_aplayer.Location = new System.Drawing.Point(181, 351);
            this.l_aplayer.Name = "l_aplayer";
            this.l_aplayer.Size = new System.Drawing.Size(61, 19);
            this.l_aplayer.TabIndex = 12;
            this.l_aplayer.Text = "PLAYERS";
            this.l_aplayer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_anpc
            // 
            this.l_anpc.AutoSize = true;
            this.l_anpc.Location = new System.Drawing.Point(295, 351);
            this.l_anpc.Name = "l_anpc";
            this.l_anpc.Size = new System.Drawing.Size(41, 19);
            this.l_anpc.TabIndex = 13;
            this.l_anpc.Text = "NPCs";
            this.l_anpc.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_amob
            // 
            this.l_amob.AutoSize = true;
            this.l_amob.Location = new System.Drawing.Point(385, 351);
            this.l_amob.Name = "l_amob";
            this.l_amob.Size = new System.Drawing.Size(45, 19);
            this.l_amob.TabIndex = 14;
            this.l_amob.Text = "MOBs";
            this.l_amob.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // l_aitem
            // 
            this.l_aitem.AutoSize = true;
            this.l_aitem.Location = new System.Drawing.Point(479, 351);
            this.l_aitem.Name = "l_aitem";
            this.l_aitem.Size = new System.Drawing.Size(43, 19);
            this.l_aitem.TabIndex = 15;
            this.l_aitem.Text = "ITEMs";
            this.l_aitem.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 376);
            this.Controls.Add(this.l_aitem);
            this.Controls.Add(this.l_amob);
            this.Controls.Add(this.l_anpc);
            this.Controls.Add(this.l_aplayer);
            this.Controls.Add(this.l_mapId);
            this.Controls.Add(this.l_target);
            this.Controls.Add(this.l_jlvl);
            this.Controls.Add(this.l_lvl);
            this.Controls.Add(this.l_pos);
            this.Controls.Add(this.l_gold);
            this.Controls.Add(this.l_mp);
            this.Controls.Add(this.l_hp);
            this.Controls.Add(this.l_nickname);
            this.Controls.Add(this.pb_hp);
            this.Controls.Add(this.pb_mp);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "NosC#";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar pb_mp;
        private MetroFramework.Controls.MetroProgressBar pb_hp;
        private MetroFramework.Controls.MetroLabel l_nickname;
        private System.Windows.Forms.Timer timer_refresh;
        private MetroFramework.Controls.MetroLabel l_hp;
        private MetroFramework.Controls.MetroLabel l_mp;
        private MetroFramework.Controls.MetroLabel l_gold;
        private MetroFramework.Controls.MetroLabel l_pos;
        private MetroFramework.Controls.MetroLabel l_lvl;
        private MetroFramework.Controls.MetroLabel l_jlvl;
        private MetroFramework.Controls.MetroLabel l_target;
        private MetroFramework.Controls.MetroLabel l_mapId;
        private MetroFramework.Controls.MetroLabel l_aplayer;
        private MetroFramework.Controls.MetroLabel l_anpc;
        private MetroFramework.Controls.MetroLabel l_amob;
        private MetroFramework.Controls.MetroLabel l_aitem;
    }
}

