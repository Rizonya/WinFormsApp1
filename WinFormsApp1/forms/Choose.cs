using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
namespace WinFormsApp1.forms
{
    public partial class Choose : Form
    {
        ModelContext context;
        public Choose()
        {
            InitializeComponent();
            context = new ModelContext();
            Servicecb.Items.AddRange(context.Услугиs.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.selectedService = (Услуги)Servicecb.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int area = 0;
            string message = "";
            if (Servicecb.SelectedItem == null)
            {
                message += "Выберите Услугу";
            }
            if (string.IsNullOrEmpty(Area.Text) || !int.TryParse(Area.Text, out area))
            {
                message += "\nВведите корректную площадь помещения";
            }
            if (message == "")
            {
                this.Hide();
                Storage.Area = area;
                Application a = new Application();
                a.Show();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int area;
            if (int.TryParse(Area.Text, out area))
            {
                Услуги service = Storage.selectedService;
                PriceLabel.Text = ((area >= 20 ? area : 20) * service.ЦенаЗаКвМ).ToString();
            }
            else
            {
                MessageBox.Show("В поле\"Площадь помещения\" должно быть число без постороннего текста ");
            }
        }

        private void Choose_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
