using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.DataBase;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dataGridView5.DataSource = orderSource;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var query = DataBase.orders.AsEnumerable();
            DateTime selectedDate = dateTimePickerFiltOrder.Value.Date;
            query = query.Where(o => o.timeOrder.Date == selectedDate);
            int minSum;
            if (int.TryParse(textBoxFiltOrderSum.Text, out minSum))
            {
                query = query.Where(o => o.priceOrder >= minSum);
            }
            var result = query.ToList();
            dataGridView5.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
