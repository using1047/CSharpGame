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
    public partial class Window_Hunt : Form
    {
        public Window_Hunt()
        {
            InitializeComponent();
        }

        public delegate void page_sub_EventHandler(string str_value);
        public event page_sub_EventHandler textSend;

        private void btn_squ_Click(object sender, EventArgs e)
        {
            textSend("다람쥐");
        }

        private void btn_rab_Click(object sender, EventArgs e)
        {
            textSend("토끼");
        }

        private void btn_negu_Click(object sender, EventArgs e)
        {
            textSend("너구리");
        }

        private void btn_piz_Click(object sender, EventArgs e)
        {
            textSend("비둘기");
        }
    }
}
