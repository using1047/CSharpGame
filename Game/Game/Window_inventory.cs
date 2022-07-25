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
    public partial class Window_inventory : Form
    {
        public Window_inventory()
        {
            InitializeComponent();
        }

        private void Window_inventory_Load(object sender, EventArgs e)
        {
            /*
            Inventory[] inventory = new Inventory[5];
            for (int i = 0; i < inventory.Count(); i++)
            {
                inventory[i]= new Inventory();
                int point = inventory[i].Width * i;
                inventory[i].Location = new Point(point, 0);
                this.Controls.Add(inventory[i]);
                inventory[i].Show();
            }
            */
        }
    }
}
