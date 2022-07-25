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
    public partial class Window_cook : Form
    {
        public Window_cook()
        {
            InitializeComponent();
        }


        public delegate void page_sub_EventHandler(string str_value);
        public event page_sub_EventHandler textSend;

        private void btn_1_Click(object sender, EventArgs e)
        {
            textSend("묵");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textSend("구이");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textSend("꼬치");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textSend("날개");
        }
    }
}
