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
    public partial class ClientsFiz : Form
    {
        public ClientsFiz()
        {
            InitializeComponent();
            ShowClientsFiz();
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientsFizSet clientsFizSet = new ClientsFizSet();
            clientsFizSet.FirstName = textBoxFirstName.Text;
            clientsFizSet.LastName = textBoxLastName.Text;
            clientsFizSet.MiddleName = textBoxMiddleName.Text;
            clientsFizSet.Phone = textBoxPhone.Text;
            Program.asdf.ClientsFizSet.Add(clientsFizSet);
            Program.asdf.SaveChanges();
            ShowClientsFiz();
        }
        void ShowClientsFiz()
        {
            listViewClientsFiz.Items.Clear();
            foreach (ClientsFizSet clientsFizSet in Program.asdf.ClientsFizSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsFizSet.ID.ToString(),clientsFizSet.FirstName,clientsFizSet.LastName,
                    clientsFizSet.MiddleName, clientsFizSet.Phone
                });
                item.Tag = clientsFizSet;
                listViewClientsFiz.Items.Add(item);
            }
            listViewClientsFiz.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClientsFiz.SelectedItems.Count == 1)
            {
                ClientsFizSet clientsFizSet = listViewClientsFiz.SelectedItems[0].Tag as ClientsFizSet;
                clientsFizSet.FirstName = textBoxFirstName.Text;
                clientsFizSet.LastName = textBoxLastName.Text;
                clientsFizSet.MiddleName = textBoxMiddleName.Text;
                clientsFizSet.Phone = textBoxPhone.Text;
                Program.asdf.SaveChanges();
                ShowClientsFiz();
            }
        }

        private void listViewClientsFiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClientsFiz.SelectedItems.Count == 1)
            {
                ClientsFizSet clientsFizSet = listViewClientsFiz.SelectedItems[0].Tag as ClientsFizSet;
                textBoxFirstName.Text = clientsFizSet.FirstName;
                textBoxLastName.Text = clientsFizSet.LastName;
                textBoxMiddleName.Text = clientsFizSet.MiddleName;
                textBoxPhone.Text = clientsFizSet.Phone;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClientsFiz.SelectedItems.Count == 1)
                {
                    ClientsFizSet clientsFizSet = listViewClientsFiz.SelectedItems[0].Tag as ClientsFizSet;
                    Program.asdf.ClientsFizSet.Remove(clientsFizSet);
                    Program.asdf.SaveChanges();
                    ShowClientsFiz();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
