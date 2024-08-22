using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ClothStore2
{
    public partial class add_form5 : Form
    {
        DataBase dataBase = new DataBase();
        public add_form5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_form5_Load(object sender, EventArgs e)
        {

        }

        private void soh25_button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int prodid;
            var name5 = name5_textBox2.Text;
            var adress5 = adress_textBox3.Text;
            var bank5 = bank5_textBox4.Text;

            if (int.TryParse(idpost_textBox1.Text, out prodid))
            {
                var addQuery5 = $"insert into producer (producerid, name, adress, bank_requisites) values ('{prodid}', '{name5}', '{adress5}', '{bank5}')";

                var command5 = new NpgsqlCommand(addQuery5, dataBase.getConnection());
                command5.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID должен иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }
    }
}
