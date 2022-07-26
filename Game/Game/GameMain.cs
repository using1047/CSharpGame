using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameMain : Form
    {
        int lucky = 0;
        int str = 0;
        int agilty = 0;
        int brain = 0;
        int move = 10;
        int max_move = 100;
        int money = 0;

        public GameMain()
        {
            InitializeComponent();

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 20000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (move < max_move)
            {
                move++;
                StatusUpdate();
            }
        }

        private void StatusUpdate()
        {
            lbl_str.Text = str.ToString();
            lbl_agilty.Text = agilty.ToString();
            lbl_brain.Text = brain.ToString();
            lbl_move.Text = move.ToString() + "/" + max_move.ToString();
            lbl_lucky.Text = lucky.ToString();
            lbl_money.Text = money.ToString();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            pnl_game.Controls.Clear();
            Window_inventory wi = new Window_inventory();
            wi.TopLevel = false;
            pnl_game.Controls.Add(wi);
            wi.Show();
        }

        private void GameMain_Load(object sender, EventArgs e)
        {
            StatusUpdate();
        }

        private void GameMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_quest_Click(object sender, EventArgs e)
        {
            pnl_game.Controls.Clear();
            Window_quest wq = new Window_quest();
            wq.TopLevel = false;
            pnl_game.Controls.Add(wq);
            wq.Show();
        }

        private void btn_cook_Click(object sender, EventArgs e)
        {
            pnl_game.Controls.Clear();
            Window_cook wc = new Window_cook();
            wc.TopLevel = false;
            pnl_game.Controls.Add(wc);
            wc.Show();
            wc.textSend += new Window_cook.page_sub_EventHandler(sub_Cook);
        }
        private void btn_hunt_Click(object sender, EventArgs e)
        {
            pnl_game.Controls.Clear();
            Window_Hunt wh = new Window_Hunt();
            wh.TopLevel = false;
            pnl_game.Controls.Add(wh);
            wh.Show();
            wh.textSend += new Window_Hunt.page_sub_EventHandler(sub_getText);
        }

        public void sub_Cook(string text)
        {
            string data = text;

            switch(data)
            {
                case "묵":
                    if(get_item(1000))str++;
                    break;
                case "구이":
                    if (get_item(2000)) agilty++;
                    break;
                case "꼬치":
                    if (get_item(3000)) brain++;
                    break;
                case "날개":
                    if (get_item(4000)) max_move++;
                    break;
            }
            StatusUpdate();
        }

        public bool get_item(int prize)
        {
            if (money < prize)
            {
                MessageBox.Show("돈이 부족합니다.");
                return false;
            }
            else
            {
                money -= prize;
                return true;
            }
        }

        public void sub_getText(string text)
        {
            string data = text;

            switch (data)
            {
                case "다람쥐":
                    Hunter(1, data);
                    break;
                case "토끼":
                    Hunter(2, data);
                    break;
                case "너구리":
                    Hunter(3, data);
                    break;
                case "비둘기":
                    Hunter(4, data);
                    break;
            }

            StatusUpdate();
        }

        public void Hunter(int movepoint, string MonsterName)
        {
            if (move < movepoint) MessageBox.Show("행동력이 없습니다.");
            else
            {
                move = move - movepoint;
                rtb_log.Text += MonsterName + "을 사냥했습니다.\n";
                Random random = new Random();
                int m = random.Next(0, 100);
                money += m;
                rtb_log.Text += m.ToString() + "원을 주웠습니다.\n";
            }
        }

        private void sAVEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string Save = "";
            Save += money + "\n";
            Save += str + "\n";
            Save += agilty + "\n";
            Save += brain + "\n";
            Save += move + "\n";
            Save += max_move + "\n";
            System.IO.File.WriteAllText(@"C:\Users\rlaql\OneDrive\바탕 화면\save.txt", Save);
        }
    }
}
