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
    public partial class add_form6 : Form
    {
        DataBase dataBase = new DataBase();
        public add_form6()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_form6_Load(object sender, EventArgs e)
        {

        }

        private void soh26_button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var fio6 = fio6_textBox1.Text;
            int buyerid;

            if (int.TryParse(idbuyer_textBox2.Text, out buyerid))
            {
                var addQuery6 = $"insert into buyer (fio_buyer, buyerid) values ('{fio6}', '{buyerid}')";

                var command6 = new NpgsqlCommand(addQuery6, dataBase.getConnection());
                command6.ExecuteNonQuery();

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
