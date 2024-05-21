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
    public partial class AddService : Form
    {
        ModelContext context;
        public AddService()
        {
            InitializeComponent();
            context = new ModelContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nametb.Text;
                int price;

                if (!int.TryParse(pricetb.Text, out price))
                {
                    MessageBox.Show("Введите корректную цену");
                    return;
                }

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Введите наименование услуги");
                    return;
                }

                // Создаем новый объект Услуги
                Услуги service = new Услуги
                {
                    Id = context.Услугиs.OrderBy(e=>e.Id).Last().Id+1,
                    ЦенаЗаКвМ = price,
                    ВидУслуги = name
                };

                // Добавляем объект в контекст
                dynamic en = context.Услугиs.Add(service);
               

                // Сохраняем изменения в базе данных
                context.SaveChanges();

                // Уведомляем пользователя об успешном добавлении
                MessageBox.Show("Услуга успешно добавлена.");
            }
            catch (Exception ex)
            {
                // Логгирование сообщения об ошибке и внутреннего исключения для диагностики
                Console.WriteLine($"Error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }

                MessageBox.Show($"Произошла ошибка при добавлении услуги: {ex.Message}");
            }
        }
    }
}
