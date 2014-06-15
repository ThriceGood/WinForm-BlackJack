namespace Big_Project
{
    partial class myProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myProgram));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.amnt_wallet = new System.Windows.Forms.Label();
            this.betbox = new System.Windows.Forms.TextBox();
            this.bet_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.amnt_pot = new System.Windows.Forms.Label();
            this.hand_dealer = new System.Windows.Forms.TextBox();
            this.hand_player = new System.Windows.Forms.TextBox();
            this.hit_btn = new System.Windows.Forms.Button();
            this.stick_btn = new System.Windows.Forms.Button();
            this.total_dealer = new System.Windows.Forms.Label();
            this.total_player = new System.Windows.Forms.Label();
            this.dealer_talk = new System.Windows.Forms.TextBox();
            this.backgroundWorker_dealersGo = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_checkLoop = new System.ComponentModel.BackgroundWorker();
            this.deal_btn = new System.Windows.Forms.Button();
            this.newGame_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker_checkLose = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wallet";
            // 
            // amnt_wallet
            // 
            this.amnt_wallet.AutoSize = true;
            this.amnt_wallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amnt_wallet.Location = new System.Drawing.Point(529, 141);
            this.amnt_wallet.Name = "amnt_wallet";
            this.amnt_wallet.Size = new System.Drawing.Size(18, 20);
            this.amnt_wallet.TabIndex = 2;
            this.amnt_wallet.Text = "0";
            // 
            // betbox
            // 
            this.betbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betbox.Location = new System.Drawing.Point(315, 109);
            this.betbox.Name = "betbox";
            this.betbox.Size = new System.Drawing.Size(100, 26);
            this.betbox.TabIndex = 3;
            // 
            // bet_btn
            // 
            this.bet_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet_btn.Location = new System.Drawing.Point(421, 109);
            this.bet_btn.Name = "bet_btn";
            this.bet_btn.Size = new System.Drawing.Size(75, 29);
            this.bet_btn.TabIndex = 4;
            this.bet_btn.Text = "Bet";
            this.bet_btn.UseVisualStyleBackColor = true;
            this.bet_btn.Click += new System.EventHandler(this.bet_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pot";
            // 
            // amnt_pot
            // 
            this.amnt_pot.AutoSize = true;
            this.amnt_pot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amnt_pot.Location = new System.Drawing.Point(620, 141);
            this.amnt_pot.Name = "amnt_pot";
            this.amnt_pot.Size = new System.Drawing.Size(18, 20);
            this.amnt_pot.TabIndex = 6;
            this.amnt_pot.Text = "0";
            // 
            // hand_dealer
            // 
            this.hand_dealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hand_dealer.Location = new System.Drawing.Point(103, 334);
            this.hand_dealer.Name = "hand_dealer";
            this.hand_dealer.ReadOnly = true;
            this.hand_dealer.Size = new System.Drawing.Size(393, 26);
            this.hand_dealer.TabIndex = 7;
            // 
            // hand_player
            // 
            this.hand_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hand_player.Location = new System.Drawing.Point(103, 391);
            this.hand_player.Name = "hand_player";
            this.hand_player.ReadOnly = true;
            this.hand_player.Size = new System.Drawing.Size(393, 26);
            this.hand_player.TabIndex = 8;
            // 
            // hit_btn
            // 
            this.hit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hit_btn.Location = new System.Drawing.Point(39, 453);
            this.hit_btn.Name = "hit_btn";
            this.hit_btn.Size = new System.Drawing.Size(75, 32);
            this.hit_btn.TabIndex = 9;
            this.hit_btn.Text = "Hit!";
            this.hit_btn.UseVisualStyleBackColor = true;
            this.hit_btn.Click += new System.EventHandler(this.hit_btn_Click);
            // 
            // stick_btn
            // 
            this.stick_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stick_btn.Location = new System.Drawing.Point(140, 453);
            this.stick_btn.Name = "stick_btn";
            this.stick_btn.Size = new System.Drawing.Size(75, 32);
            this.stick_btn.TabIndex = 10;
            this.stick_btn.Text = "Stand";
            this.stick_btn.UseVisualStyleBackColor = true;
            this.stick_btn.Click += new System.EventHandler(this.stick_btn_Click);
            // 
            // total_dealer
            // 
            this.total_dealer.AutoSize = true;
            this.total_dealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_dealer.Location = new System.Drawing.Point(620, 333);
            this.total_dealer.Name = "total_dealer";
            this.total_dealer.Size = new System.Drawing.Size(18, 20);
            this.total_dealer.TabIndex = 11;
            this.total_dealer.Text = "0";
            // 
            // total_player
            // 
            this.total_player.AutoSize = true;
            this.total_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_player.Location = new System.Drawing.Point(620, 397);
            this.total_player.Name = "total_player";
            this.total_player.Size = new System.Drawing.Size(18, 20);
            this.total_player.TabIndex = 12;
            this.total_player.Text = "0";
            // 
            // dealer_talk
            // 
            this.dealer_talk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealer_talk.Location = new System.Drawing.Point(39, 260);
            this.dealer_talk.Name = "dealer_talk";
            this.dealer_talk.ReadOnly = true;
            this.dealer_talk.Size = new System.Drawing.Size(457, 29);
            this.dealer_talk.TabIndex = 13;
            this.dealer_talk.Text = "Press \'New game\' to play BlackJack";
            // 
            // backgroundWorker_dealersGo
            // 
            this.backgroundWorker_dealersGo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_dealersGo_DoWork);
            // 
            // backgroundWorker_checkLoop
            // 
            this.backgroundWorker_checkLoop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_checkLoop_DoWork);
            // 
            // deal_btn
            // 
            this.deal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deal_btn.Location = new System.Drawing.Point(456, 504);
            this.deal_btn.Name = "deal_btn";
            this.deal_btn.Size = new System.Drawing.Size(96, 30);
            this.deal_btn.TabIndex = 14;
            this.deal_btn.Text = "Deal";
            this.deal_btn.UseVisualStyleBackColor = true;
            this.deal_btn.Click += new System.EventHandler(this.deal_btn_Click);
            // 
            // newGame_Btn
            // 
            this.newGame_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame_Btn.Location = new System.Drawing.Point(579, 504);
            this.newGame_Btn.Name = "newGame_Btn";
            this.newGame_Btn.Size = new System.Drawing.Size(96, 30);
            this.newGame_Btn.TabIndex = 15;
            this.newGame_Btn.Text = "New game";
            this.newGame_Btn.UseVisualStyleBackColor = true;
            this.newGame_Btn.Click += new System.EventHandler(this.newGame_Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(66, 26);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Dealer :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(39, 391);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(66, 26);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Player :";
            // 
            // backgroundWorker_checkLose
            // 
            this.backgroundWorker_checkLose.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_checkLose_DoWork);
            // 
            // myProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newGame_Btn);
            this.Controls.Add(this.deal_btn);
            this.Controls.Add(this.dealer_talk);
            this.Controls.Add(this.total_player);
            this.Controls.Add(this.total_dealer);
            this.Controls.Add(this.stick_btn);
            this.Controls.Add(this.hit_btn);
            this.Controls.Add(this.hand_player);
            this.Controls.Add(this.hand_dealer);
            this.Controls.Add(this.amnt_pot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bet_btn);
            this.Controls.Add(this.betbox);
            this.Controls.Add(this.amnt_wallet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "myProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.myProgram_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amnt_wallet;
        private System.Windows.Forms.TextBox betbox;
        private System.Windows.Forms.Button bet_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label amnt_pot;
        private System.Windows.Forms.TextBox hand_dealer;
        private System.Windows.Forms.TextBox hand_player;
        private System.Windows.Forms.Button hit_btn;
        private System.Windows.Forms.Button stick_btn;
        private System.Windows.Forms.Label total_dealer;
        private System.Windows.Forms.Label total_player;
        private System.Windows.Forms.TextBox dealer_talk;
        private System.ComponentModel.BackgroundWorker backgroundWorker_dealersGo;
        private System.ComponentModel.BackgroundWorker backgroundWorker_checkLoop;
        private System.Windows.Forms.Button deal_btn;
        private System.Windows.Forms.Button newGame_Btn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker_checkLose;
    }
}