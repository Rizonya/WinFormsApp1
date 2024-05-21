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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.forms
{
    public partial class ViewOrders : Form
    {
        ModelContext context;
        public ViewOrders()
        {
            InitializeComponent();
            context = new ModelContext();
            InitLV();
            PopulateLV();
        }
        private void InitLV()
        {
            Orderslv.View = View.Details;
            Orderslv.FullRowSelect = true;
            Orderslv.GridLines = true;
            Orderslv.Columns.Add("Id", 50);
            Orderslv.Columns.Add("Вид Услуги", 100);
            Orderslv.Columns.Add("Заказчик", 100);
            Orderslv.Columns.Add("Дата", 100);
            Orderslv.Columns.Add("Время", 100);
            Orderslv.Columns.Add("Адрес", 150);
            Orderslv.Columns.Add("Площадь", 70);
            Orderslv.Columns.Add("Цена", 70);
            Orderslv.Columns.Add("Статус", 50);
            this.Controls.Add(Orderslv);
        }
        private void PopulateLV()
        {
            Orderslv.Items.Clear();
            foreach (var заказ in context.Заказыs)
            {
                var row = new ListViewItem(заказ.Id.ToString());
                row.SubItems.Add(заказ.ВидУслуги?.ToString());
                row.SubItems.Add(заказ.Заказчик);
                row.SubItems.Add(заказ.Дата?.ToShortDateString());
                row.SubItems.Add(заказ.Время?.ToShortTimeString());
                row.SubItems.Add(заказ.Адрес);
                row.SubItems.Add(заказ.Площадь?.ToString());
                row.SubItems.Add(заказ.Цена?.ToString("F2"));
                row.SubItems.Add(заказ.ВыполненоИлиНет =="Да" ? "✅" : "❌");
                Orderslv.Items.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.Заказыs.First(e => e.Id == int.Parse(Orderslv.SelectedItems[0].Text)).ВыполненоИлиНет = "Да";
            context.SaveChanges();
            PopulateLV();

        }
    }
}
