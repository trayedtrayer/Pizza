using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using static WinFormsApp1.Form1;
using static WinFormsApp1.DataBase;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //красивые названия
        int savedIndex;
        bool isCombo = false;
        Pizza tempForEdit;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.ShowUpDown = true;
            ingridients = new BindingList<Ingridient>()
            {
                new Ingridient("Мука", 15),
                new Ingridient("Дрожжи", 25),
                new Ingridient("Соль", 5),
                new Ingridient("Сахар", 8),
                new Ingridient("Масло оливковое", 120),
                new Ingridient("Чеснок", 30),
                new Ingridient("Томатный соус", 80),
                new Ingridient("Сыр моцарелла", 350),
                new Ingridient("Сыр пармезан", 450),
                new Ingridient("Пепперони", 280),
                new Ingridient("Ветчина", 220),
                new Ingridient("Грибы", 95),
                new Ingridient("Маслины", 110),
                new Ingridient("Курица", 180),
                new Ingridient("Бекон", 320),
                new Ingridient("Перец болгарский", 75),
                new Ingridient("Лук красный", 45)
            };
            pizzaMain = new BindingList<PizzaMain>()
            {
                new PizzaMain("Классическое", 100),
                new PizzaMain("Тонкое хрустящее", 100),
                new PizzaMain("Пышное итальянское", 120),
                new PizzaMain("На цельнозерновой основе", 90),
                new PizzaMain("Безглютеновое", 100)
            };
            borders = new BindingList<Border>()
            {
                new Border("Сырный бортик", 150),
                new Border("Чесночный бортик", 80),
                new Border("Сливочный бортик", 120)
            };
            pizza = new BindingList<Pizza>()
            {
                new Pizza("Маргарита",
                    new List<Ingridient> { ingridients[6], ingridients[7]},
                    pizzaMain[1], borders[0], new List<Border> { borders[0],borders[2] }),
                new Pizza("Пепперони",
                    new List<Ingridient> { ingridients[6], ingridients[7], ingridients[12] },
                    pizzaMain[0], borders[1], new List<Border> { borders[1],borders[2] }),
                new Pizza("4 Сыра",
                    new List<Ingridient> { ingridients[7], ingridients[8], ingridients[9], ingridients[10] },
                    pizzaMain[2], borders[2], new List<Border> { borders[1],borders[2] })
            };
            var order1 = new Order
            {
                timeOrder = DateTime.Now.Date.AddHours(10),    // сегодня 10:00
                comment = "Самовывоз",
                pizzas = new List<PizzaInOrder>
            {
                new PizzaInOrder
                {
                    pizzaA = pizza[0],
                    pizzaB = null,
                    countPizza = 2,
                }
            }
            };

            var order2 = new Order
            {
                timeOrder = DateTime.Now.Date.AddDays(-1).AddHours(19), // вчера 19:00
                comment = "Доставка, без лука",
                pizzas = new List<PizzaInOrder>
                {
                    new PizzaInOrder
                    {
                        pizzaA = pizza[1],
                        pizzaB = null,
                        countPizza = 1,
                    },
                    new PizzaInOrder
                    {
                        pizzaA = pizza[2],
                        pizzaB = null,
                        countPizza = 1,
                    }
                }
            };

            var order3 = new Order
            {
                timeOrder = DateTime.Now.Date.AddDays(-2).AddHours(14),
                comment = "Офисный заказ",
                pizzas = new List<PizzaInOrder>
                {
                    new PizzaInOrder
                    {
                        pizzaA = pizza[0],
                        pizzaB = pizza[1],
                        countPizza = 3,
                    }
                },
                delayed = null
            };
            orders = new BindingList<Order> { order1, order2, order3 };
            dataGridView1.DataSource = ingredientsSource;
            dataGridView2.DataSource = mainSource;
            dataGridView3.DataSource = borderSource;
            dataGridView4.DataSource = pizzaSource;
            dataGridView5.DataSource = orderSource;
            dataGridView6.DataSource = pizzaInOrderSource;
            ((ListBox)checkedListBoxBordersList).DataSource = borderSource;
            ((ListBox)checkedListBoxBorder).DataSource = borderSource;
            ((ListBox)checkedListBoxIngredients).DataSource = ingredientsSource;
            ((ListBox)checkedListBoxPizza).DataSource = pizza;
            ((ListBox)checkedListBoxForBorderSort).DataSource = pizza;
            ((ListBox)checkedListBoxForPizzaInOrder).DataSource = tempiPizzas;
            ((ListBox)checkedListBoxForPizzaInOrder2).DataSource = tempiPizzas;
            ((ListBox)checkedListBoxFlitPizza1).DataSource = ingredientsSource;
            ((ListBox)checkedListBoxFlitPizza2).DataSource = mainSource;
            ((ListBox)checkedListBoxFlitPizza3).DataSource = borderSource;
            comboBoxForSizePizza.DataSource = Enum.GetValues(typeof(PizzaSize));
            comboBoxForSizePizza.SelectedIndex = 1;
            comboBoxPizzaMain.DataSource = mainSource;
            ingredientsSource.DataSource = ingridients;
            mainSource.DataSource = pizzaMain;
            borderSource.DataSource = borders;
            pizzaSource.DataSource = pizza;
            orderSource.DataSource = orders;
            pizzaInOrderSource.DataSource = pizzasInOrder;
            comboBoxForPizzaMainInOrder.DataSource = mainSource;
            //temp.Text = pizzaMain.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textNameIngr.Text) && int.TryParse(TextCostIngred.Text, out int cost))
            {
                ingridients.Add(new Ingridient(textNameIngr.Text, int.Parse(TextCostIngred.Text)));
                textNameIngr.Clear();
                TextCostIngred.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textNameMain.Text) && int.TryParse(TextCostMain.Text, out int cost))
            {
                pizzaMain.Add(new PizzaMain(textNameMain.Text, int.Parse(TextCostMain.Text)));
                textNameMain.Clear();
                TextCostMain.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textNameBorder.Text) && int.TryParse(textCostBorder.Text, out int cost))
            {
                borders.Add(new Border(textNameBorder.Text, int.Parse(textCostBorder.Text)));
                textNameBorder.Clear();
                textCostBorder.Clear();
                foreach (var pizzaCheck in checkedListBoxPizza.CheckedItems)
                {
                    //temp.Text = "123123";
                    Pizza pizza = (Pizza)pizzaCheck;
                    pizza.borderList.Add(borders[borders.Count - 1]);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    break;

                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    tempiPizzas.Clear();
                    foreach (var p in pizza)
                        tempiPizzas.Add(p);
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pizza pizzaAdd = new Pizza();
            foreach (var border in checkedListBoxBordersList.CheckedItems)
            {
                pizzaAdd.borderList.Add((Border)border);
            }
            foreach (var border in checkedListBoxBorder.CheckedItems)
            {
                pizzaAdd.pizzaBorder = (Border)border;
            }
            pizzaAdd.pizzasMain = pizzaMain[comboBoxPizzaMain.SelectedIndex];
            foreach (var ingredient in checkedListBoxIngredients.CheckedItems)
            {
                pizzaAdd.ingridientsPizza.Add((Ingridient)ingredient);
            }
            pizzaAdd.name = textBoxNamePizza.Text;
            pizza.Add(pizzaAdd);
        }

        private void checkedListBoxBorder_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBoxBorder.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBoxBorder.SetItemChecked(i, false);
                }
                else
                {
                    if (!checkedListBoxBordersList.GetItemChecked(i))
                    {
                        checkedListBoxBordersList.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void buttonDeleteIngr_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows.Count.ToString();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    ingridients.RemoveAt(row.Index);
                    label2.Text = row.Index.ToString();
                }
            }
        }

        private void buttonDeleteMain_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    if (row.Index != 0)
                    {
                        pizzaMain.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void buttonDeleteBorders_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView3.SelectedRows)
                {
                    borders.RemoveAt(row.Index);
                }
            }
        }

        private void buttonDeletePizza_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView4.SelectedRows)
                {
                    pizza.RemoveAt(row.Index);
                }
            }
        }

        private void buttonEditBorders_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow?.DataBoundItem is Border border)
            {
                foreach (Pizza pizzaT in pizza)
                {
                    pizzaT.borderList.Clear();
                }
                foreach (var item in checkedListBoxPizza.CheckedItems)
                {
                    Pizza pizzaT = (Pizza)item;
                    pizzaT.borderList.Add(border);
                }
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow?.DataBoundItem is Border border)
            {
                LoadBordersPizza(border);
            }
        }

        private void LoadBordersPizza(Border border)
        {
            for (int i = 0; i < pizza.Count; i++)
            {
                checkedListBoxPizza.SetItemChecked(i, false);
            }
            for (int i = 0; i < pizza.Count; i++)
            {
                Pizza pizzaT = pizza[i];
                if (pizzaT.borderList.Contains(border))
                {
                    checkedListBoxPizza.SetItemChecked(i, true);
                }
            }
        }

        private void LoadPizza(Pizza pizzaT)
        {
            for (int i = 0; i < borders.Count; i++)
            {
                if (pizzaT.borderList.Contains(borders[i]))
                {
                    checkedListBoxBordersList.SetItemChecked(i, true);
                }
            }
            pizzaT.borderList.Clear();
            for (int i = 0; i < borders.Count; i++)
            {
                if (pizzaT.pizzaBorder == borders[i])
                {
                    checkedListBoxBorder.SetItemChecked(i, true);
                    break;
                }
            }
            pizzaT.pizzaBorder = new Border();
            for (int i = 0; i < ingridients.Count; i++)
            {
                if (pizzaT.ingridientsPizza.Contains(ingridients[i]))
                {
                    checkedListBoxIngredients.SetItemChecked(i, true);
                }
            }
            pizzaT.ingridientsPizza.Clear();
            for (int i = 0; i < pizzaMain.Count; i++)
            {
                if (pizzaT.pizzasMain == pizzaMain[i])
                {
                    comboBoxPizzaMain.SelectedIndex = i;
                    break;
                }
            }
            pizzaT.pizzasMain = new PizzaMain();
        }

        private void buttonEditPizza_Click(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow?.DataBoundItem is Pizza pizzaT)
            {
                savedIndex = dataGridView4.CurrentRow.Index;
                tempForEdit = pizzaT;
                LoadPizza(tempForEdit);
                SetVisibleForEdit();
                buttonSaveChanges.Visible = true;
                dataGridView4.CurrentCell = dataGridView4[0, savedIndex];
                dataGridView4.FirstDisplayedScrollingRowIndex = savedIndex;
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxBordersList.Items.Count; i++)
            {
                if (checkedListBoxBordersList.GetItemChecked(i) == true)
                {
                    tempForEdit.borderList.Add((Border)checkedListBoxBordersList.Items[i]);
                    checkedListBoxBordersList.SetItemChecked(i, false);
                }
                else
                {
                    checkedListBoxBordersList.SetItemChecked(i, false);
                }
            }
            for (int i = 0; i < checkedListBoxBorder.Items.Count; i++)
            {
                if (checkedListBoxBorder.GetItemChecked(i) == true)
                {
                    tempForEdit.pizzaBorder = (Border)checkedListBoxBorder.Items[i];
                    checkedListBoxBorder.SetItemChecked(i, false);
                }
            }
            tempForEdit.pizzasMain = pizzaMain[comboBoxPizzaMain.SelectedIndex];
            for (int i = 0; i < checkedListBoxIngredients.Items.Count; i++)
            {
                if (checkedListBoxIngredients.GetItemChecked(i) == true)
                {
                    tempForEdit.ingridientsPizza.Add((Ingridient)checkedListBoxIngredients.Items[i]);
                    checkedListBoxIngredients.SetItemChecked(i, false);
                }
            }
            SetVisibleForEdit();
        }

        void SetVisibleForEdit()
        {
            buttonSaveChanges.Visible = !buttonSaveChanges.Visible;
            button6.Visible = !button6.Visible;
            buttonDeletePizza.Visible = !buttonDeletePizza.Visible;
            textBoxNamePizza.Visible = !textBoxNamePizza.Visible;
            label8.Visible = !label8.Visible;
            textBoxFiltPizza1.Visible = !textBoxFiltPizza1.Visible;
            textBoxFiltPizza2.Visible = !textBoxFiltPizza2.Visible;
            label15.Visible = !label15.Visible;
            label16.Visible = !label16.Visible;
            button9.Visible = !button9.Visible;
            label29.Visible = !label29.Visible;
            label30.Visible = !label30.Visible;
            label31.Visible = !label31.Visible;
            checkedListBoxFlitPizza1.Visible = !checkedListBoxFlitPizza1.Visible;
            checkedListBoxFlitPizza2.Visible = !checkedListBoxFlitPizza2.Visible;
            checkedListBoxFlitPizza3.Visible = !checkedListBoxFlitPizza3.Visible;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
            {
                if (buttonSaveChanges.Visible)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if (buttonSaveChanges.Visible)
            {
                dataGridView4.CurrentCell = dataGridView4[0, savedIndex];
                dataGridView4.FirstDisplayedScrollingRowIndex = savedIndex;
            }
        }

        public void ValidateCell(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string nameColumn = dataGridView1.Columns[e.ColumnIndex].Name;
            string err = e.FormattedValue.ToString();
            if (nameColumn == "price")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int res) || res < 0)
                {
                    MessageBox.Show("неверный формат");
                    e.Cancel = true;
                }
                else if (nameColumn == "")
                {

                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidPrice(sender, e, dataGridView1);
        }

        public void ValidPrice(object sender, DataGridViewCellValidatingEventArgs e, DataGridView dataGridView)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "price")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int res) || res < 0)
                {
                    MessageBox.Show("неверный формат");
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidPrice(sender, e, dataGridView2);
            string err = e.FormattedValue.ToString();
            if (dataGridView2.Columns[e.ColumnIndex].Name == "price")
            {
                if (e.RowIndex != 0)
                {
                    int priceMain = pizzaMain[0].price;
                    int priceMy = int.Parse(err);
                    if (int.Parse(err) > (int)(priceMain * 1.2) || int.Parse(err) < (int)(priceMain * 0.8))
                    {
                        MessageBox.Show("стоимость не может измениться более чем на 20%");
                        e.Cancel = true;
                    }
                }
                else
                {
                    pizzaMain[0].price = int.Parse(err);
                    int minLim = (int)(pizzaMain[0].price * 0.8);
                    label4.Text = minLim.ToString();
                    int maxLim = (int)(pizzaMain[0].price * 1.2);
                    label3.Text = maxLim.ToString();
                    for (int i = 1; i < pizzaMain.Count; i++)
                    {
                        if (pizzaMain[i].price > maxLim)
                        {
                            pizzaMain[i].price = maxLim;
                        }
                        if (pizzaMain[i].price < minLim)
                        {
                            pizzaMain[i].price = minLim;
                        }
                    }
                    mainSource.ResetBindings(false);
                }
            }
        }

        private void dataGridView3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidPrice(sender, e, dataGridView3);
        }

        private void buttonForAddInOrder_Click(object sender, EventArgs e)
        {
            PizzaInOrder pizzaT = new PizzaInOrder();
            for (int i = 0; i < checkedListBoxForPizzaInOrder.Items.Count; i++)
            {
                if (checkedListBoxForPizzaInOrder.GetItemChecked(i))
                {
                    pizzaT.pizzaA = pizza[i];
                    pizzaT.pizzaA.pizzaBorder = pizzaT.pizzaA.borderList[comboBoxForPizzaA.SelectedIndex];
                    pizzaT.borderA = pizzaT.pizzaA.pizzaBorder;
                    checkedListBoxForPizzaInOrder.SetItemChecked(i, false);
                }
            }
            for (int i = 0; i < checkedListBoxForPizzaInOrder2.Items.Count; i++)
            {
                if (checkedListBoxForPizzaInOrder2.GetItemChecked(i))
                {
                    pizzaT.pizzaB = pizza[i];
                    pizzaT.pizzaB.pizzaBorder = pizzaT.pizzaB.borderList[comboBoxForPizzaB.SelectedIndex];
                    pizzaT.borderB = pizzaT.pizzaB.pizzaBorder;
                    checkedListBoxForPizzaInOrder.SetItemChecked(i, false);
                }
            }
            pizzaT.pizzaMain = pizzaMain[comboBoxForPizzaMainInOrder.SelectedIndex];
            pizzaT.isDoubleIngredients = checkBoxForDouble.Checked;
            checkBoxForDouble.Checked = false;
            pizzaT.sizePizza = (PizzaSize)comboBoxForSizePizza.SelectedIndex;
            label7.Text = ((PizzaSize)comboBoxForSizePizza.SelectedIndex).ToString();
            comboBoxForSizePizza.SelectedIndex = 1;
            pizzaT.countPizza = (int)numericUpDownForCountPizza.Value;
            numericUpDownForCountPizza.Value = 1;
            pizzasInOrder.Add(pizzaT);
        }

        private void checkedListBoxForPizzaInOrder_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckOnlyOne(e, checkedListBoxForPizzaInOrder);
            var pizzaA = (Pizza)checkedListBoxForPizzaInOrder.Items[e.Index];
            comboBoxForPizzaA.DataSource = null;
            comboBoxForPizzaA.DataSource = pizzaA.borderList;
        }

        private void checkedListBoxForPizzaInOrder2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckOnlyOne(e, checkedListBoxForPizzaInOrder2);
            var pizzaA = (Pizza)checkedListBoxForPizzaInOrder2.Items[e.Index];
            comboBoxForPizzaB.DataSource = null;
            comboBoxForPizzaB.DataSource = pizzaA.borderList;
        }

        private void buttonOpenForm_Click(object sender, EventArgs e)
        {
            using (var f = new FormEditPizza())
            {
                if (f.ShowDialog(this) == DialogResult.OK && f.resultPizza != null)
                {
                    Pizza p = f.resultPizza;
                    tempiPizzas.Add(p);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            newOrder.pizzas = pizzasInOrder.ToList();
            newOrder.comment = textBoxComment.Text;
            if (checkBox1.Checked)
            {
                newOrder.delayed = dateTimePicker1.Value;
            }
            else
            {
                newOrder.delayed = null;
            }
            orders.Add(newOrder);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = checkBox1.Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nameText = textBoxNameIngrFilter.Text;
            int minPrice;
            bool hasPrice = int.TryParse(textBoxPriceFilter.Text, out minPrice);
            if (!hasPrice) { minPrice = 0; }
            var filtered = FilterHelper.FilterByPriceName(ingridients, minPrice, nameText);
            dataGridView1.DataSource = filtered;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string nameText = textBoxPizzaMainFilterName.Text;
            int minPrice;
            bool hasPrice = int.TryParse(textBoxPizzaMainFilterPrice.Text, out minPrice);
            if (!hasPrice) { minPrice = 0; }
            var filtered = FilterHelper.FilterByPriceName(pizzaMain, minPrice, nameText);
            dataGridView2.DataSource = filtered;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<Pizza> pizzas = new List<Pizza>();
            foreach (var piz in checkedListBoxForBorderSort.CheckedItems)
            {
                pizzas.Add((Pizza)piz);
            }
            var usedBorders = borders.Where(b => pizzas.Any(p => p.borderList.Contains(b))).ToList();
            int minPrice;
            bool hasPrice = int.TryParse(textBoxPizzaMainFilterPrice.Text, out minPrice);
            if (!hasPrice) { minPrice = 0; }
            var finBord = FilterHelper.FilterByPriceName(usedBorders, minPrice, textBoxBordFiltName.Text);
            dataGridView3.DataSource = finBord;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var query = pizza.AsEnumerable();
            if (checkedListBoxFlitPizza2.SelectedIndex >= 0 && checkedListBoxFlitPizza2.GetItemChecked(checkedListBoxFlitPizza2.SelectedIndex) ? true : false)
            {
                var selectedMain = (PizzaMain)checkedListBoxFlitPizza2.Items[checkedListBoxFlitPizza2.SelectedIndex];
                query = query.Where(p => p.pizzasMain == selectedMain);
            }

            if (checkedListBoxFlitPizza3.SelectedIndex >= 0 && checkedListBoxFlitPizza3.GetItemChecked(checkedListBoxFlitPizza3.SelectedIndex) ? true : false)
            {
                var selectedBorder = (Border)checkedListBoxFlitPizza3.Items[checkedListBoxFlitPizza3.SelectedIndex];
                query = query.Where(p => p.pizzaBorder == selectedBorder);
            }

            var selectedIngr = checkedListBoxFlitPizza1.CheckedItems.Cast<Ingridient>().ToList();
            label16.Text = query.Count().ToString();

            if (selectedIngr.Count > 0)
            {
                query = query.Where(p => p.ingridientsPizza.Any(i => selectedIngr.Contains(i)));
            }
            int minPrice;
            if (int.TryParse(textBoxFiltPizza2.Text, out minPrice))
            {
                query = query.Where(p => p.price >= minPrice);
            }

            var nameText = textBoxFiltPizza1.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(nameText))
            {
                nameText = nameText.ToLower();
                query = query.Where(p => p.name.ToLower().Contains(nameText));
            }
            var finPizza = query.ToList();
            dataGridView4.DataSource = finPizza;
        }

        void CheckOnlyOne(ItemCheckEventArgs e, CheckedListBox checkList)
        {
            for (int i = 0; i < checkList.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkList.SetItemChecked(i, false);
                }
            }
        }

        private void buttonOpenFilt_Click(object sender, EventArgs e)
        {
            var f = new Form3();
            f.ShowDialog(this);
        }

        private void checkedListBoxFlitPizza1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckOnlyOne(e, checkedListBoxFlitPizza1);
        }

        private void checkedListBoxFlitPizza2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckOnlyOne(e, checkedListBoxFlitPizza2);
        }

        private void checkedListBoxFlitPizza3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckOnlyOne(e, checkedListBoxFlitPizza3);
        }
    }
}