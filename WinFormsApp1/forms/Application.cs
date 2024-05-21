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
    public partial class Application : Form
    {
        ModelContext context;
        public Application()
        {
            InitializeComponent();
            datePicker.Format = DateTimePickerFormat.Short;
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            context = new ModelContext();

        }

        private void application_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = datePicker.Value.Date; // Берём только дату без времени
            DateTime time = timePicker.Value; // Берём только время без даты

            // Объединяем дату и время
            DateTime dateTime = date.Add(time.TimeOfDay);
            Заказчики client = new Заказчики();
            //создаем новый объект класса Заказы
            Заказы order = new Заказы
            {
                Id = context.Заказыs.OrderBy(e=>e.Id).Last().Id+1,
                Заказчик = Nametb.Text,
                Дата = date,
                Время = time,
                ВидУслуги = Storage.selectedService.Id,
                Адрес = Addresstb.Text,
                Площадь = Storage.Area,
                Цена = (Storage.Area >= 20 ? Storage.Area : 20) * Storage.selectedService.ЦенаЗаКвМ
            };
            //получаем подтверждение данных от пользователя
            DialogResult result = MessageBox.Show($"Выбранная услуга: {context.Услугиs.First(e=>e.Id==order.ВидУслуги)}\n" +
                $"Введенная площадь помещения: {order.Площадь}\n" +
                $"Дата: {order.Дата.Value.ToString("yyyy-MM-dd")}\n" +
                $"Время: {order.Время.Value.TimeOfDay}\n Адрес: {order.Адрес}\n" +
                $"Заказчик: {order.Заказчик}\n" +
                $"Цена: {order.Цена}\n" +
                $"Адрес: {order.Адрес}", "Подтверждение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //добавляем данные в базу
                context.Заказыs.Add(order);
                context.SaveChanges();
                MessageBox.Show("Заявка успешно сохранена");
            }
            
        }
        private void Application_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
