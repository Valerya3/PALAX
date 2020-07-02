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
    public partial class ClientsYour : Form
    {
        public ClientsYour()
        {
            InitializeComponent();
            ShowClientsYour();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientsYourSet clientsYourSet = new ClientsYourSet();
            clientsYourSet.Name = textBoxName.Text;
            clientsYourSet.Adress = textBoxAdress.Text;
            clientsYourSet.Date = dateTimePickerDate.Value;
            clientsYourSet.Phone = textBoxPhone.Text;
            Program.asdf.ClientsYourSet.Add(clientsYourSet);
            Program.asdf.SaveChanges();
            ShowClientsYour();
        }

        void ShowClientsYour()
        {
            listViewClientsYour.Items.Clear();
            foreach (ClientsYourSet clientsYourSet in Program.asdf.ClientsYourSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsYourSet.ID.ToString(),clientsYourSet.Name,clientsYourSet.Adress,
                    clientsYourSet.Date.ToString().Substring(0, clientsYourSet.Date.ToString().Length - 8), 
                    clientsYourSet.Phone
                });
                item.Tag = clientsYourSet;
                listViewClientsYour.Items.Add(item);
            }
            listViewClientsYour.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClientsYour.SelectedItems.Count == 1)
            {
                ClientsYourSet clientsYourSet = listViewClientsYour.SelectedItems[0].Tag as ClientsYourSet;
                clientsYourSet.Name = textBoxName.Text;
                clientsYourSet.Adress = textBoxAdress.Text;
                clientsYourSet.Date = dateTimePickerDate.Value;
                clientsYourSet.Phone = textBoxPhone.Text;
                Program.asdf.SaveChanges();
                ShowClientsYour();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClientsYour.SelectedItems.Count == 1)
                {
                    ClientsYourSet clientsYourSet = listViewClientsYour.SelectedItems[0].Tag as ClientsYourSet;
                    Program.asdf.ClientsYourSet.Remove(clientsYourSet);
                    Program.asdf.SaveChanges();
                    ShowClientsYour();
                }
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                dateTimePickerDate.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewClientsYour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClientsYour.SelectedItems.Count == 1)
            {
                ClientsYourSet clientsYourSet = listViewClientsYour.SelectedItems[0].Tag as ClientsYourSet;
                textBoxName.Text = clientsYourSet.Name;
                clientsYourSet.Adress = textBoxAdress.Text;
                clientsYourSet.Date = dateTimePickerDate.Value;
                textBoxPhone.Text = clientsYourSet.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                dateTimePickerDate.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
