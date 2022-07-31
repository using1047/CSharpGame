
namespace Game
{
    partial class GameMain
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
            this.pn_left = new System.Windows.Forms.Panel();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_hunt = new System.Windows.Forms.Button();
            this.btn_cook = new System.Windows.Forms.Button();
            this.btn_quest = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.lbl_money = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_move = new System.Windows.Forms.Label();
            this.lbl_brain = new System.Windows.Forms.Label();
            this.lbl_agilty = new System.Windows.Forms.Label();
            this.lbl_str = new System.Windows.Forms.Label();
            this.lbl_lucky = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_game = new System.Windows.Forms.Panel();
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_left.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.pnl_status.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_left
            // 
            this.pn_left.Controls.Add(this.pnl_menu);
            this.pn_left.Controls.Add(this.pnl_status);
            this.pn_left.Controls.Add(this.pnl_top);
            this.pn_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_left.Location = new System.Drawing.Point(0, 0);
            this.pn_left.Name = "pn_left";
            this.pn_left.Size = new System.Drawing.Size(271, 503);
            this.pn_left.TabIndex = 2;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.btn_hunt);
            this.pnl_menu.Controls.Add(this.btn_cook);
            this.pnl_menu.Controls.Add(this.btn_quest);
            this.pnl_menu.Controls.Add(this.btn_inventory);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_menu.Location = new System.Drawing.Point(0, 277);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(271, 223);
            this.pnl_menu.TabIndex = 2;
            // 
            // btn_hunt
            // 
            this.btn_hunt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hunt.Location = new System.Drawing.Point(0, 162);
            this.btn_hunt.Name = "btn_hunt";
            this.btn_hunt.Size = new System.Drawing.Size(271, 54);
            this.btn_hunt.TabIndex = 3;
            this.btn_hunt.Text = "사냥";
            this.btn_hunt.UseVisualStyleBackColor = true;
            this.btn_hunt.Click += new System.EventHandler(this.btn_hunt_Click);
            // 
            // btn_cook
            // 
            this.btn_cook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cook.Location = new System.Drawing.Point(0, 108);
            this.btn_cook.Name = "btn_cook";
            this.btn_cook.Size = new System.Drawing.Size(271, 54);
            this.btn_cook.TabIndex = 2;
            this.btn_cook.Text = "요리";
            this.btn_cook.UseVisualStyleBackColor = true;
            this.btn_cook.Click += new System.EventHandler(this.btn_cook_Click);
            // 
            // btn_quest
            // 
            this.btn_quest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_quest.Location = new System.Drawing.Point(0, 54);
            this.btn_quest.Name = "btn_quest";
            this.btn_quest.Size = new System.Drawing.Size(271, 54);
            this.btn_quest.TabIndex = 1;
            this.btn_quest.Text = "퀘스트";
            this.btn_quest.UseVisualStyleBackColor = true;
            this.btn_quest.Click += new System.EventHandler(this.btn_quest_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inventory.Location = new System.Drawing.Point(0, 0);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(271, 54);
            this.btn_inventory.TabIndex = 0;
            this.btn_inventory.Text = "인벤토리";
            this.btn_inventory.UseVisualStyleBackColor = true;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // pnl_status
            // 
            this.pnl_status.Controls.Add(this.lbl_money);
            this.pnl_status.Controls.Add(this.label7);
            this.pnl_status.Controls.Add(this.lbl_move);
            this.pnl_status.Controls.Add(this.lbl_brain);
            this.pnl_status.Controls.Add(this.lbl_agilty);
            this.pnl_status.Controls.Add(this.lbl_str);
            this.pnl_status.Controls.Add(this.lbl_lucky);
            this.pnl_status.Controls.Add(this.label5);
            this.pnl_status.Controls.Add(this.label4);
            this.pnl_status.Controls.Add(this.label3);
            this.pnl_status.Controls.Add(this.label2);
            this.pnl_status.Controls.Add(this.label1);
            this.pnl_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_status.Location = new System.Drawing.Point(0, 93);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(271, 184);
            this.pnl_status.TabIndex = 1;
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Location = new System.Drawing.Point(69, 89);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(15, 15);
            this.lbl_money.TabIndex = 11;
            this.lbl_money.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "돈";
            // 
            // lbl_move
            // 
            this.lbl_move.AutoSize = true;
            this.lbl_move.Location = new System.Drawing.Point(69, 74);
            this.lbl_move.Name = "lbl_move";
            this.lbl_move.Size = new System.Drawing.Size(15, 15);
            this.lbl_move.TabIndex = 9;
            this.lbl_move.Text = "0";
            // 
            // lbl_brain
            // 
            this.lbl_brain.AutoSize = true;
            this.lbl_brain.Location = new System.Drawing.Point(69, 59);
            this.lbl_brain.Name = "lbl_brain";
            this.lbl_brain.Size = new System.Drawing.Size(15, 15);
            this.lbl_brain.TabIndex = 8;
            this.lbl_brain.Text = "0";
            // 
            // lbl_agilty
            // 
            this.lbl_agilty.AutoSize = true;
            this.lbl_agilty.Location = new System.Drawing.Point(69, 44);
            this.lbl_agilty.Name = "lbl_agilty";
            this.lbl_agilty.Size = new System.Drawing.Size(15, 15);
            this.lbl_agilty.TabIndex = 7;
            this.lbl_agilty.Text = "0";
            // 
            // lbl_str
            // 
            this.lbl_str.AutoSize = true;
            this.lbl_str.Location = new System.Drawing.Point(69, 29);
            this.lbl_str.Name = "lbl_str";
            this.lbl_str.Size = new System.Drawing.Size(15, 15);
            this.lbl_str.TabIndex = 6;
            this.lbl_str.Text = "0";
            // 
            // lbl_lucky
            // 
            this.lbl_lucky.AutoSize = true;
            this.lbl_lucky.Location = new System.Drawing.Point(69, 14);
            this.lbl_lucky.Name = "lbl_lucky";
            this.lbl_lucky.Size = new System.Drawing.Size(15, 15);
            this.lbl_lucky.TabIndex = 5;
            this.lbl_lucky.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "활동력";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "지능";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "민첩";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "힘";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "행운";
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.menuStrip1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(271, 93);
            this.pnl_top.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAVEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAVEToolStripMenuItem1,
            this.loadToolStripMenuItem});
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.sAVEToolStripMenuItem.Text = "Menu";
            // 
            // sAVEToolStripMenuItem1
            // 
            this.sAVEToolStripMenuItem1.Name = "sAVEToolStripMenuItem1";
            this.sAVEToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.sAVEToolStripMenuItem1.Text = "SAVE";
            this.sAVEToolStripMenuItem1.Click += new System.EventHandler(this.sAVEToolStripMenuItem1_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pnl_game);
            this.pnl_main.Controls.Add(this.rtb_log);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(271, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(511, 503);
            this.pnl_main.TabIndex = 3;
            // 
            // pnl_game
            // 
            this.pnl_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_game.Location = new System.Drawing.Point(0, 0);
            this.pnl_game.Name = "pnl_game";
            this.pnl_game.Size = new System.Drawing.Size(511, 356);
            this.pnl_game.TabIndex = 1;
            // 
            // rtb_log
            // 
            this.rtb_log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtb_log.Location = new System.Drawing.Point(0, 356);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.Size = new System.Drawing.Size(511, 147);
            this.rtb_log.TabIndex = 0;
            this.rtb_log.Text = "";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pn_left);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "GameMain";
            this.Text = "GameMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameMain_FormClosing);
            this.Load += new System.EventHandler(this.GameMain_Load);
            this.pn_left.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_status.ResumeLayout(false);
            this.pnl_status.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_left;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Label lbl_move;
        private System.Windows.Forms.Label lbl_brain;
        private System.Windows.Forms.Label lbl_agilty;
        private System.Windows.Forms.Label lbl_str;
        private System.Windows.Forms.Label lbl_lucky;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_cook;
        private System.Windows.Forms.Button btn_quest;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.RichTextBox rtb_log;
        private System.Windows.Forms.Panel pnl_game;
        private System.Windows.Forms.Button btn_hunt;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}