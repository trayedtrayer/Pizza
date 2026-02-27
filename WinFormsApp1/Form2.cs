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
    public partial class FormEditPizza : Form
    {

        public Pizza resultPizza = new Pizza();

        public FormEditPizza()
        {
            InitializeComponent();
            SetUpWindow();
        }

        public void SetUpWindow()
        {
            ((ListBox)checkedListBoxIngredientsModal).DataSource = ingredientsSource;
            ((ListBox)checkedListBoxModalBorder).DataSource = borderSource;
            comboBoxPizzaMainModal.DataSource = mainSource;
        }

        private void checkedListBoxModalBorder_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNamePizzaModal.Text) && checkedListBoxModalBorder.SelectedIndex != -1)
            {
                List<Border> avBor = new List<Border>();
                foreach (var p in checkedListBoxModalBorder.CheckedItems)
                    avBor.Add((Border)p);
                resultPizza.borderList = avBor;
                for (int i = 0; i < ingridients.Count; i++)
                {
                    if(checkedListBoxIngredientsModal.GetItemChecked(i) == true)
                    {
                        resultPizza.ingridientsPizza.Add(ingridients[i]);
                    }
                }
                resultPizza.pizzasMain = pizzaMain[comboBoxPizzaMainModal.SelectedIndex];
                resultPizza.name = textBoxNamePizzaModal.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
