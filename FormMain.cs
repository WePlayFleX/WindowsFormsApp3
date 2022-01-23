using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            // Проверка на пустую строку или NULL
            if ((!String.IsNullOrWhiteSpace(tbName.Text)) && (!String.IsNullOrWhiteSpace(tbSurname.Text)) &&
                (!String.IsNullOrWhiteSpace(tbEmail.Text)) && (!String.IsNullOrWhiteSpace(tbPhone.Text)))
            {
                var student = new Student()
                {
                    name = tbName.Text,
                    surName = tbSurname.Text,
                    email = tbEmail.Text,
                    phone = tbPhone.Text,
                };
                // Проверка на наличие данной строки в Items элемента ListBox
                if (!ListBox.Items.Contains(tbName.Text))
                {
                    // Добавление строки в Items элемента ListBox
                    ListBox.Items.Add(student);
                }
                else
                {
                    MessageBox.Show("Данная строка(-ки) уже имеется в Списке!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            // Проверка на наличие элементов
            if (ListBox.Items.Count != 0)
            {
                // Проверка на наличие выбранных строк 
                if (ListBox.SelectedItems != null)
                {
                    // Перебор всех выбранных строк в элементе listBox1
                    for (int i = 0; i < ListBox.SelectedItems.Count; i++)
                    {
                        // Удаление строки из Items
                        ListBox.Items.Remove(ListBox.SelectedItems[i]);
                    }
                }
            }

        }
    }
}
