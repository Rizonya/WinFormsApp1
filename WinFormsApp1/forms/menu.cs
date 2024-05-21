using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1.forms
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choose c = new Choose();
            c.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddService ac = new AddService();
            ac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewOrders vo = new ViewOrders();
            vo.ShowDialog();
        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
