namespace Nos_CSharp
{
    partial class liste
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
            this.lv_player = new System.Windows.Forms.ListView();
            this.timer_refresh_liste = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lv_player
            // 
            this.lv_player.Location = new System.Drawing.Point(12, 30);
            this.lv_player.Name = "lv_player";
            this.lv_player.Size = new System.Drawing.Size(286, 404);
            this.lv_player.TabIndex = 1;
            this.lv_player.UseCompatibleStateImageBehavior = false;
            this.lv_player.View = System.Windows.Forms.View.Details;
            // 
            // timer_refresh_liste
            // 
            this.timer_refresh_liste.Tick += new System.EventHandler(this.timer_refresh_liste_Tick);
            // 
            // liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 471);
            this.Controls.Add(this.lv_player);
            this.Name = "liste";
            this.Text = "liste";
            this.Load += new System.EventHandler(this.liste_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_player;
        private System.Windows.Forms.Timer timer_refresh_liste;
    }
}