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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            ShowStaff();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StaffSet staffSet = new StaffSet();
            staffSet.FirstName = textBoxFirstName.Text;
            staffSet.LastName = textBoxLastName.Text;
            staffSet.MiddleName = textBoxMiddleName.Text;
            staffSet.Phone = textBoxPhone.Text;
            staffSet.Email = textBoxEmail.Text;
            staffSet.Persent = textBoxPersent.Text;
            Program.asdf.StaffSet.Add(staffSet);
            Program.asdf.SaveChanges();
            ShowStaff();
        }
        void ShowStaff()
        {
            listViewStaff.Items.Clear();
            foreach (StaffSet staffSet in Program.asdf.StaffSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    staffSet.ID.ToString(),staffSet.FirstName,staffSet.LastName,
                    staffSet.MiddleName, staffSet.Phone,  staffSet.Email, staffSet.Persent
                });
                item.Tag = staffSet;
                listViewStaff.Items.Add(item);
            }
            listViewStaff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedItems.Count == 1)
            {
                StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;
                staffSet.FirstName = textBoxFirstName.Text;
                staffSet.LastName = textBoxLastName.Text;
                staffSet.MiddleName = textBoxMiddleName.Text;
                staffSet.Phone = textBoxPhone.Text;
                staffSet.Email = textBoxEmail.Text;
                staffSet.Persent = textBoxPersent.Text;
                Program.asdf.SaveChanges();
                ShowStaff();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStaff.SelectedItems.Count == 1)
                {
                    StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;
                    Program.asdf.StaffSet.Remove(staffSet);
                    Program.asdf.SaveChanges();
                    ShowStaff();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxPersent.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void listViewStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedItems.Count == 1)
            {
                StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;
                textBoxFirstName.Text = staffSet.FirstName;
                textBoxLastName.Text = staffSet.LastName;
                textBoxMiddleName.Text = staffSet.MiddleName;
                textBoxPhone.Text = staffSet.Phone;
                textBoxEmail.Text = staffSet.Email;
                textBoxPersent.Text = staffSet.Persent;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxPersent.Text = "";

            }
        }

        private void labelPersent_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPersent_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
