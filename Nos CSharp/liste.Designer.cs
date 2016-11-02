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
            this.lb_player = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_player
            // 
            this.lb_player.FormattingEnabled = true;
            this.lb_player.Location = new System.Drawing.Point(12, 12);
            this.lb_player.Name = "lb_player";
            this.lb_player.Size = new System.Drawing.Size(291, 459);
            this.lb_player.TabIndex = 0;
            // 
            // liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 471);
            this.Controls.Add(this.lb_player);
            this.Name = "liste";
            this.Text = "liste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_player;
    }
}