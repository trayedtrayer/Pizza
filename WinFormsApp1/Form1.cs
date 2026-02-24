using System.ComponentModel;
using static WinFormsApp1.Form1;
using System.Linq;
using System.Reflection;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //создание пиццы из доступных, фильтрация, красивые названия, каждая половинка свой бортик, тыкнуть guid куда нить
        int savedIndex;
        bool isCombo = false;
        Pizza tempForEdit;
        BindingSource ingredientsSource = new BindingSource();
        BindingSource mainSource = new BindingSource();
        BindingSource pizzaSource = new BindingSource();
        BindingSource borderSource = new BindingSource();
        BindingSource orderSource = new BindingSource();
        BindingSource pizzaInOrderSource = new BindingSource();

        BindingList<Ingridient> ingridients = new BindingList<Ingridient>();
        BindingList<PizzaMain> pizzaMain = new BindingList<PizzaMain>();
        BindingList<Pizza> pizza = new BindingList<Pizza>();
        BindingList<Border> borders = new BindingList<Border>();
        BindingList<Order> orders = new BindingList<Order>();
        BindingList<PizzaInOrder> pizzasInOrder = new BindingList<PizzaInOrder>();
        public class Ingridient
        {
            public override string ToString()
            {
                return nameIngridient ?? "";
            }
            private string _nameIngridient;
            [DisplayName("Название Ингредиента")]
            public string nameIngridient
            {
                get { return _nameIngridient; }
                set { _nameIngridient = value; }
            }
            private int _price;
            [DisplayName("Цена в руб.")]
            public int price
            {
                get { return _price; }
                set { _price = value; }
            }
            [DisplayName("Выбран")]
            public bool isSelected { get; set; }
            public Ingridient() { }

            public Ingridient(string nameIngridient, int price)
            {
                this.nameIngridient = nameIngridient;
                this.price = price;
            }
        }
        public class PizzaMain
        {
            public override string ToString()
            {
                return namePizzaMain ?? "";
            }
            private string _namePizzaMain;
            [DisplayName("Название теста")]
            public string namePizzaMain
            {
                get { return _namePizzaMain; }
                set { _namePizzaMain = value; }
            }
            private int _price;
            [DisplayName("Цена в руб.")]
            public int price
            {
                get { return _price; }
                set { _price = value; }
            }
            [DisplayName("Выбран")]
            public bool isSelected { get; set; }

            public PizzaMain() { }

            public PizzaMain(string namePizzaMain, int price)
            {
                this.namePizzaMain = namePizzaMain;
                this.price = price;
            }
        }

        public class Border
        {
            public override string ToString()
            {
                return nameBorder ?? "";
            }
            string _nameBorder;
            [DisplayName("Название бортика")]
            public string nameBorder
            {
                get { return _nameBorder; }
                set { _nameBorder = value; }
            }
            [DisplayName("Стоимость бортика")]
            public int price { get; set; }
            public Border(string namePizzaMain, int price)
            {
                this.nameBorder = namePizzaMain;
                this.price = price;
            }
            public Border() { }
        }

        public class PizzaInOrder()
        {
            public Pizza pizzaA { get; set; }
            public Pizza pizzaB { get; set; }
            public bool isDoubleIngredients { get; set; }
            public PizzaSize sizePizza { get; set; }
            public int countPizza { get; set; } = 1;
            public int priceFor
            {
                get
                {
                    int sum = 0;
                    if (pizzaB != null)
                    {
                        sum = PriceChangeDouble();
                    }
                    else
                    {
                        sum = PriceChangeSolo();
                    }
                    return sum;
                }
            }

            private int PriceChangeSolo()
            {
                int basicPrice = pizzaA.price;
                int multiplier = (int)sizePizza+1;
                int dopIngr = isDoubleIngredients ? pizzaA.ReturnIngredientsPrice() * 1 : 0;
                return basicPrice + dopIngr;
            }
            private int PriceChangeDouble()
            {
                int basicPrice = pizzaA.price + pizzaB.price;
                int multiplier = (int)sizePizza+1;
                int dopIngrA = isDoubleIngredients ? pizzaA.ReturnIngredientsPrice() * 1 : 0;
                int dopIngrB = isDoubleIngredients ? pizzaB.ReturnIngredientsPrice() * 1 : 0;
                return basicPrice * multiplier + dopIngrA + dopIngrB;
            }
        }

        public class Order
        {
            public int numberOrder { get; set; }
            public List<PizzaInOrder> pizzas { get; set; } = new List<PizzaInOrder>();
            public int priceOrder => pizzas.Sum(p => p.priceFor * p.countPizza);
            public string comment { get; set; } = "";
            public DateTime timeOrder { get; set; } = DateTime.Now;
            public DateTime? delayed { get; set; }
            public bool isDelayed => delayed.HasValue;
        }

        public class Pizza
        {
            public override string ToString()
            {
                return namePizza ?? "";
            }
            private string _namePizza;
            [DisplayName("Название пиццы")]
            public string namePizza
            {
                get { return _namePizza; }
                set { _namePizza = value; }
            }
            [DisplayName("Цена в руб.")]
            public int price
            {
                get
                {
                    int sum = 0;
                    foreach (var _ingridient in ingridientsPizza)
                    {
                        sum += _ingridient.price;
                    }
                    sum += pizzaBorder.price;
                    sum += pizzasMain.price;
                    return sum;
                }
            }
            public List<Ingridient> ingridientsPizza { get; set; } = new List<Ingridient>();
            [DisplayName("Состав")]
            public string ingredientsDisplay
            {
                get
                {
                    if (ingridientsPizza == null || ingridientsPizza.Count == 0)
                    {
                        return "Без ингредиентов";
                    }
                    string res = "";
                    foreach (var ingredient in ingridientsPizza)
                    {
                        res += (res == "" ? "" : ", ") + ingredient.nameIngridient;
                    }
                    return res;
                }
            }
            [DisplayName("Тесто")]
            public string pizzaMainDisplay
            {
                get
                {
                    return pizzasMain.namePizzaMain;
                }
            }
            [Browsable(false)]
            public PizzaMain pizzasMain { get; set; } = new PizzaMain();
            [Browsable(false)]
            public Border pizzaBorder { get; set; } = new Border();
            [DisplayName("Бортик")]
            public string nameBorder
            {
                get
                {
                    return pizzaBorder.nameBorder;
                }
            }
            [Browsable(false)]
            public List<Border> borderList { get; set; } = new List<Border>();

            public int ReturnIngredientsPrice()
            {
                int sum = 0;
                foreach (var _ingridient in ingridientsPizza)
                {
                    sum += _ingridient.price;
                }
                return sum;
            }

            public Pizza() { }

            public Pizza(string namePizza, List<Ingridient> ingridientsPizza, PizzaMain pizzasMain, Border pizzaBorder)
            {
                this.namePizza = namePizza;
                this.ingridientsPizza = ingridientsPizza;
                this.pizzasMain = pizzasMain;
                this.pizzaBorder = pizzaBorder;
            }
        }

        public enum PizzaSize
        {
            Small = 0,
            Medium = 1,
            Large = 2,
        }

        public Form1()
        {
            InitializeComponent();
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
                    pizzaMain[1], borders[0]),
                new Pizza("Пепперони",
                    new List<Ingridient> { ingridients[6], ingridients[7], ingridients[12] },
                    pizzaMain[0], borders[1]),
                new Pizza("4 Сыра",
                    new List<Ingridient> { ingridients[7], ingridients[8], ingridients[9], ingridients[10] },
                    pizzaMain[2], borders[2])
            };

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
            ((ListBox)checkedListBoxForPizzaInOrder).DataSource = pizza;
            comboBoxForSizePizza.DataSource = Enum.GetValues(typeof(PizzaSize));
            comboBoxForSizePizza.SelectedIndex = 1;
            comboBoxPizzaMain.DataSource = mainSource;
            ingredientsSource.DataSource = ingridients;
            mainSource.DataSource = pizzaMain;
            borderSource.DataSource = borders;
            pizzaSource.DataSource = pizza;
            orderSource.DataSource = orders;
            pizzaInOrderSource.DataSource = pizzasInOrder;
            temp.Text = pizzaMain.Count.ToString();
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
                    temp.Text = "123123";
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
            pizzaAdd.namePizza = textBoxNamePizza.Text;
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
            }
            for (int i = 0; i < checkedListBoxBorder.Items.Count; i++)
            {
                if (checkedListBoxBorder.GetItemChecked(i) == true)
                {
                    tempForEdit.pizzaBorder = (Border)checkedListBoxBorder.Items[i];
                    checkedListBoxBorder.SetItemChecked(i, false);
                    break;
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
            SetInvisibleForEdit();
        }

        void SetVisibleForEdit()
        {
            buttonSaveChanges.Visible = true;
            button6.Visible = false;
            buttonDeletePizza.Visible = false;
            textBoxNamePizza.Visible = false;
            label8.Visible = false;
        }

        void SetInvisibleForEdit()
        {
            buttonSaveChanges.Visible = false;
            button6.Visible = true;
            buttonDeletePizza.Visible = true;
            textBoxNamePizza.Visible = true;
            label8.Visible = true;
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
            if (isCombo)
            {
                for(int i = 0; i < checkedListBoxForPizzaInOrder.Items.Count;i++)
                {
                    if (checkedListBoxForPizzaInOrder.GetItemChecked(i))
                    {
                        pizzaT.pizzaA = pizza[i];
                        checkedListBoxForPizzaInOrder.SetItemChecked(i, false);
                        break;
                    }
                }
                for (int i = 0; i < checkedListBoxForPizzaInOrder.Items.Count; i++)
                {
                    if (checkedListBoxForPizzaInOrder.GetItemChecked(i))
                    {
                        pizzaT.pizzaB = pizza[i];
                        checkedListBoxForPizzaInOrder.SetItemChecked(i, false);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < checkedListBoxForPizzaInOrder.Items.Count; i++)
                {
                    if (checkedListBoxForPizzaInOrder.GetItemChecked(i))
                    {
                        pizzaT.pizzaA = pizza[i];
                        checkedListBoxForPizzaInOrder.SetItemChecked(i, false);
                    }
                }
            }
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
            if (!isCombo)
            {
                for (int i = 0; i < checkedListBoxForPizzaInOrder.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBoxForPizzaInOrder.SetItemChecked(i, false);
                    }
                }
            }
            else
            {
                if (e.NewValue == CheckState.Checked && checkedListBoxForPizzaInOrder.CheckedItems.Count >= 2)
                {
                    e.NewValue = CheckState.Unchecked;
                }
            }
        }

        private void checkedListBoxForPizzaInOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxIsCombo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsCombo.Checked)
            {
                isCombo = true;
            }
            else
            {
                isCombo = false;
            }
        }
    }
}
 