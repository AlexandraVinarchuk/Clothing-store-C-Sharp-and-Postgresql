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
    public partial class add_form8 : Form
    {
        DataBase dataBase = new DataBase();
        public add_form8()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_form8_Load(object sender, EventArgs e)
        {

        }

        private void soh28_button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int numb8;
            int buyerid8;
            var bank8 = bank8_textBox3.Text;
            int directorid;
            var date8 = date8_textBox5.Text;
            int.TryParse(pokupid_textBox2.Text, out buyerid8);
            int.TryParse(dirid8_textBox4.Text, out directorid);

            if (int.TryParse(idprodaza_textBox1.Text, out numb8))
            {
                var addQuery8 = $"insert into sale_contract (numb_contrid, buyerid, req_bank, directorid, conclusion_date) values ('{numb8}', '{buyerid8}', '{bank8}', '{directorid}', '{date8}')";

                var command8 = new NpgsqlCommand(addQuery8, dataBase.getConnection());
                command8.ExecuteNonQuery();

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
