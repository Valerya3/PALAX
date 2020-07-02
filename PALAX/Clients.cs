using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PALAX
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void buttonClientsYour_Click(object sender, EventArgs e)
        {
            Form ClientsYour = new ClientsYour();
            ClientsYour.Show();
        }

        private void buttonClientsFiz_Click(object sender, EventArgs e)
        {
            Form ClientsFiz = new ClientsFiz();
            ClientsFiz.Show();
        }
    }
}
