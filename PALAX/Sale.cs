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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
            ShowStaff();
            ShowClients();
            ShowSale();
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientsYourSet  clientsYourSet in Program.asdf.ClientsYourSet)
            {
                string [] item = { clientsYourSet.ID.ToString() + ".", clientsYourSet.Name };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowStaff()
        {
            comboBoxStaff.Items.Clear();
            foreach(StaffSet staffSet in Program.asdf.StaffSet)
            {
                string[] item = { staffSet.ID.ToString() + ".", staffSet.MiddleName, staffSet.FirstName, staffSet.LastName };
                comboBoxStaff.Items.Add(string.Join(" ", item));
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SaleSet saleSet = new SaleSet();
            saleSet.Prise = Convert.ToInt64(textBoxPrise.Text);
            saleSet.Data = dateTimePickerDate.Value;
            saleSet.IDStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
            saleSet.IDClientsYour = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
            Program.asdf.SaleSet.Add(saleSet);
            Program.asdf.SaveChanges();
            ShowSale();
        }

        void ShowSale()
        {
            listViewSale.Items.Clear();
            foreach (SaleSet saleSet in Program.asdf.SaleSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    saleSet.ID.ToString(),
                    saleSet.Data.ToString().Substring(0, saleSet.Data.ToString().Length - 8),
                    saleSet.IDStaff.ToString() ,
                    saleSet.IDClientsYour.ToString(),
                    saleSet.Prise.ToString()
                });
                item.Tag = saleSet;
                listViewSale.Items.Add(item);
            }
            listViewSale.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSale.SelectedItems.Count == 1)
            {
                SaleSet saleSet = listViewSale.SelectedItems[0].Tag as SaleSet;
                
                saleSet.Data.ToString().Substring(0, saleSet.Data.ToString().Length - 8);
                saleSet.IDStaff.ToString();
                saleSet.IDClientsYour.ToString();
                saleSet.Prise.ToString();
                Program.asdf.SaveChanges();
                ShowSale();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSale.SelectedItems.Count == 1)
                {
                    SaleSet saleSet = listViewSale.SelectedItems[0].Tag as SaleSet;
                    Program.asdf.SaleSet.Remove(saleSet);
                    Program.asdf.SaveChanges();
                    ShowSale();

                    dateTimePickerDate.Text = "";
                    comboBoxClient.Text = "";
                    textBoxPrise.Text = "";
                    comboBoxClient.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSale.SelectedItems.Count == 1)
            {
                SaleSet saleSet = listViewSale.SelectedItems[0].Tag as SaleSet;
                saleSet.ID.ToString();
                saleSet.Data.ToString().Substring(0, saleSet.Data.ToString().Length - 8);
                saleSet.IDStaff.ToString();
                saleSet.IDClientsYour.ToString();
                saleSet.Prise.ToString();
            }
            else
            {
                dateTimePickerDate.Text = "";
                comboBoxClient.Text = "";
                textBoxPrise.Text = "";
                comboBoxClient.Text = "";
            }
        }
    }
}
