using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PALAX
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Clients = new Clients();
            Clients.Show();
        }

        private void battonSale_Click(object sender, EventArgs e)
        {
            Form Sale = new Sale();
            Sale.Show();
        }

        private void battonStaff_Click(object sender, EventArgs e)
        {
            Form Staff = new Staff();
            Staff.Show();
        }

        private void battonLog_Click(object sender, EventArgs e)
        {
            Form Log = new Log();
            Log.Show();
        }
    }
}
