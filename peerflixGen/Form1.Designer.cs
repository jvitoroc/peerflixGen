namespace peerflixUI
{
    partial class peerflix
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.input = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.ComboBox();
            this.play = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadNodejsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peerflixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanced = new System.Windows.Forms.CheckBox();
            this.additionalLabel = new System.Windows.Forms.Label();
            this.aditionalFlags = new System.Windows.Forms.TextBox();
            this.Flags = new System.Windows.Forms.ToolTip(this.components);
            this.advancedTooltip = new System.Windows.Forms.Label();
            this.globalMode = new System.Windows.Forms.CheckBox();
            this.locallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 97);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(213, 20);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(232, 96);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(121, 23);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Magnet link or URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Or browse a .torrent file";
            // 
            // player
            // 
            this.player.FormattingEnabled = true;
            this.player.Location = new System.Drawing.Point(13, 146);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(121, 21);
            this.player.TabIndex = 4;
            this.player.Text = "Select a player...";
            this.player.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(280, 286);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 5;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pick a player";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadModulesToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fILEToolStripMenuItem.Text = "File";
            this.fILEToolStripMenuItem.Click += new System.EventHandler(this.fILEToolStripMenuItem_Click);
            // 
            // downloadModulesToolStripMenuItem
            // 
            this.downloadModulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locallyToolStripMenuItem,
            this.globallyToolStripMenuItem});
            this.downloadModulesToolStripMenuItem.Name = "downloadModulesToolStripMenuItem";
            this.downloadModulesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.downloadModulesToolStripMenuItem.Text = "Download modules";
            this.downloadModulesToolStripMenuItem.Click += new System.EventHandler(this.downloadModulesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadNodejsToolStripMenuItem,
            this.gitHubToolStripMenuItem,
            this.peerflixToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // downloadNodejsToolStripMenuItem
            // 
            this.downloadNodejsToolStripMenuItem.Name = "downloadNodejsToolStripMenuItem";
            this.downloadNodejsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.downloadNodejsToolStripMenuItem.Text = "Node.js Website";
            this.downloadNodejsToolStripMenuItem.Click += new System.EventHandler(this.downloadNodejsToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.gitHubToolStripMenuItem.Text = "Open GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // peerflixToolStripMenuItem
            // 
            this.peerflixToolStripMenuItem.Name = "peerflixToolStripMenuItem";
            this.peerflixToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.peerflixToolStripMenuItem.Text = "peerflix";
            this.peerflixToolStripMenuItem.Click += new System.EventHandler(this.peerflixToolStripMenuItem_Click);
            // 
            // advanced
            // 
            this.advanced.AutoSize = true;
            this.advanced.Location = new System.Drawing.Point(13, 192);
            this.advanced.Name = "advanced";
            this.advanced.Size = new System.Drawing.Size(75, 17);
            this.advanced.TabIndex = 9;
            this.advanced.Text = "Advanced";
            this.advanced.UseVisualStyleBackColor = true;
            this.advanced.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // additionalLabel
            // 
            this.additionalLabel.AutoSize = true;
            this.additionalLabel.Location = new System.Drawing.Point(10, 223);
            this.additionalLabel.Name = "additionalLabel";
            this.additionalLabel.Size = new System.Drawing.Size(78, 13);
            this.additionalLabel.TabIndex = 10;
            this.additionalLabel.Text = "Additional flags";
            this.additionalLabel.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // aditionalFlags
            // 
            this.aditionalFlags.Location = new System.Drawing.Point(13, 239);
            this.aditionalFlags.Name = "aditionalFlags";
            this.aditionalFlags.Size = new System.Drawing.Size(261, 20);
            this.aditionalFlags.TabIndex = 11;
            this.aditionalFlags.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Flags
            // 
            this.Flags.AutomaticDelay = 100;
            this.Flags.AutoPopDelay = 3000;
            this.Flags.InitialDelay = 100;
            this.Flags.ReshowDelay = 20;
            this.Flags.ToolTipTitle = "Flags";
            // 
            // advancedTooltip
            // 
            this.advancedTooltip.AutoSize = true;
            this.advancedTooltip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advancedTooltip.Cursor = System.Windows.Forms.Cursors.Default;
            this.advancedTooltip.Location = new System.Drawing.Point(280, 242);
            this.advancedTooltip.Name = "advancedTooltip";
            this.advancedTooltip.Size = new System.Drawing.Size(15, 15);
            this.advancedTooltip.TabIndex = 12;
            this.advancedTooltip.Text = "?";
            this.Flags.SetToolTip(this.advancedTooltip, "-a, --subtitles");
            // 
            // globalMode
            // 
            this.globalMode.AutoSize = true;
            this.globalMode.Location = new System.Drawing.Point(12, 44);
            this.globalMode.Name = "globalMode";
            this.globalMode.Size = new System.Drawing.Size(98, 17);
            this.globalMode.TabIndex = 13;
            this.globalMode.Text = "Global modules";
            this.globalMode.UseVisualStyleBackColor = true;
            this.globalMode.CheckedChanged += new System.EventHandler(this.globalMode_CheckedChanged);
            // 
            // locallyToolStripMenuItem
            // 
            this.locallyToolStripMenuItem.Name = "locallyToolStripMenuItem";
            this.locallyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.locallyToolStripMenuItem.Text = "Locally";
            this.locallyToolStripMenuItem.Click += new System.EventHandler(this.locallyToolStripMenuItem_Click);
            // 
            // globallyToolStripMenuItem
            // 
            this.globallyToolStripMenuItem.Name = "globallyToolStripMenuItem";
            this.globallyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.globallyToolStripMenuItem.Text = "Globally";
            this.globallyToolStripMenuItem.Click += new System.EventHandler(this.globallyToolStripMenuItem_Click);
            // 
            // peerflix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(367, 321);
            this.Controls.Add(this.globalMode);
            this.Controls.Add(this.advancedTooltip);
            this.Controls.Add(this.aditionalFlags);
            this.Controls.Add(this.additionalLabel);
            this.Controls.Add(this.advanced);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.play);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.input);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "peerflix";
            this.Text = "peerflixGen";
            this.Load += new System.EventHandler(this.peerflix_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox player;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox advanced;
        private System.Windows.Forms.Label additionalLabel;
        private System.Windows.Forms.TextBox aditionalFlags;
        private System.Windows.Forms.ToolTip Flags;
        private System.Windows.Forms.Label advancedTooltip;
        private System.Windows.Forms.ToolStripMenuItem downloadNodejsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peerflixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadModulesToolStripMenuItem;
        private System.Windows.Forms.CheckBox globalMode;
        private System.Windows.Forms.ToolStripMenuItem locallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globallyToolStripMenuItem;
    }
}

