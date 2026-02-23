using Microsoft.CSharp.RuntimeBinder;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms.VisualStyles;
using static WinFormsApp1.Form1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Pizza tempForMake;
        int pizzaIdT;
        int changeWhat;
        BindingSource mainSource = new BindingSource();
        BindingSource sourceForAdd = new BindingSource();
        bool isMakingPizza;
        bool isAddIngredients;
        bool isAddMain;

        bool isIngred;
        bool isPizzaMain;
        bool isPizza;

        BindingList<Ingridient> ingridients = new BindingList<Ingridient>();
        BindingList<Ingridient> ingridientsTemp;
        BindingList<PizzaMain> pizzaMain = new BindingList<PizzaMain>();
        BindingList<PizzaMain> pizzaMainTemp;
        BindingList<Pizza> pizza = new BindingList<Pizza>();
        public class Ingridient
        {
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
        public class Pizza
        {
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
                    sum += pizzaMain.price;
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
                    return pizzaMain.namePizzaMain;
                }
            }
            [Browsable(false)]
            public PizzaMain pizzaMain { get; set; } = new PizzaMain();

            public void AddIngredientsToPizza(List<Ingridient> ingridients)
            {
                ingridientsPizza.Clear();
                ingridientsPizza = new List<Ingridient>(ingridients);
            }

            public void AddPizzaMainToPizza(PizzaMain pizzasMain)
            {
                pizzaMain = pizzasMain;
            }

            public Pizza(List<Ingridient> ingridientsPizza, PizzaMain pizzaMain)
            {
                this.ingridientsPizza = ingridientsPizza;
                this.pizzaMain = pizzaMain;
            }
        }

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = mainSource;
            dataGridView2.DataSource = sourceForAdd;
            mainSource.DataSource = ingridients;
            ingridients.Add(new Ingridient("ПОмидор", 200));
            pizzaMain.Add(new PizzaMain { namePizzaMain = "Классическое", price = 1000 });
            ingridientsTemp = new BindingList<Ingridient>(ingridients);
            pizzaMainTemp = new BindingList<PizzaMain>(pizzaMain);
            button2.BringToFront();
            comboBox1.SelectedIndex = 0;
            isIngred = true;
        }

        void StartMakePizza()
        {
            tempForMake.AddPizzaMainToPizza(pizzaMain[0]);
            isMakingPizza = true;
            button1.Text = "Стоп";
        }

        void ClearTextBox(TextBox textBox)
        {
            textBox.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        void ShowAllListIngred()
        {
            mainSource.DataSource = ingridients;
        }

        void ShowAllListPizzaMain()
        {
            mainSource.DataSource = pizzaMain;
        }

        void ShowAllListPizza()
        {
            mainSource.DataSource = pizza;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MakeTrue(0);
                MakeTexts(0);
                ShowAllListIngred();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                MakeTrue(1);
                MakeTexts(1);
                MakeTrue(1);
                ShowAllListPizzaMain();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                MakeTrue(2);
                MakeTexts(2);
                ShowAllListPizza();
                button1.Visible = true;
            }
        }
        /// <summary>
        /// упрощение для булов
        /// </summary>
        /// <param name="i">0-инг 1-основ 2-пицца</param>
        void MakeTrue(int i)
        {
            if (i == 0)
            {
                isIngred = true;
                isPizzaMain = false;
                isPizza = false;
                isAddIngredients = isMakingPizza;
            }
            if (i == 1)
            {
                isIngred = false;
                isPizzaMain = true;
                isPizza = false;
                isAddMain = isMakingPizza;
            }
            if (i == 2)
            {
                isIngred = false;
                isPizzaMain = false;
                isPizza = true;
            }
        }

        void MakeTexts(int i)
        {
            if (isMakingPizza)
            {
                button3.Text = "Добавить";
            }
            if (!isMakingPizza)
            {
                button3.Text = "Удалить";
            }
            if (i == 0)
            {
                label3.Text = "список ингридиентов";
            }
            if (i == 1)
            {
                label3.Text = "основы для пиццы";
            }
            if (i == 2)
            {
                label3.Text = "виды пицц";
                button1.Visible = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell.ReadOnly = false;
            //MessageBox.Show($"ReadOnly: cell={cell.ReadOnly}, col={dataGridView1.Columns[e.ColumnIndex].ReadOnly}, grid={dataGridView1.ReadOnly}");
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string nameColumn = dataGridView1.Columns[e.ColumnIndex].Name;
            string err = e.FormattedValue.ToString();
            if (nameColumn == "price")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int res) || res < 0)
                {
                    MessageBox.Show("Неверный формат цены");
                    e.Cancel = true;
                }
                else if (isPizzaMain)
                {
                    if (e.RowIndex != 0)
                    {
                        int priceMain = pizzaMain[0].price;
                        int priceMy = int.Parse(err);
                        if (int.Parse(err) > (int)(priceMain * 1.2) || int.Parse(err) < (int)(priceMain * 0.8))
                        {
                            MessageBox.Show("Цена не может отличаться более чем на 20%");
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        int minLim = (int)(pizzaMain[0].price * 0.8);
                        int maxLim = (int)(pizzaMain[0].price * 1.2);
                        foreach (var pizMain in pizzaMain)
                        {
                            if (pizMain.price > maxLim)
                            {
                                pizMain.price = maxLim;
                            }
                            if (pizMain.price < minLim)
                            {
                                pizMain.price = minLim;
                            }
                        }
                    }
                }
            }
            if (isPizzaMain)
            {
                if (nameColumn == "namePizzaMain")
                {
                    if (err != "Классическое" && e.RowIndex == 0 && e.ColumnIndex == 0)
                    {

                        MessageBox.Show("Вы не можете изменить название этого теста");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if (isPizzaMain)
            {
                e.Row.Cells["price"].Value = pizzaMain[0].price;
                e.Row.Cells["namePizzaMain"].Value = "Новое тесто";
            }
            if (isIngred)
            {
                e.Row.Cells["price"].Value = 0;
                e.Row.Cells["nameIngridient"].Value = "Новый";
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            if (isPizzaMain)
            {
                string rowName = e.Row.Cells["namePizzaMain"].Value.ToString();
                if (rowName == "Классическое")
                {
                    MessageBox.Show("Нельзя удалить классическое тесто!");
                    e.Cancel = true;
                    AutoValidate = AutoValidate.EnablePreventFocusChange;
                    return;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "IsSelected")
            {
                dataGridView1.EndEdit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete(comboBox1.SelectedIndex);
        }

        public void Delete(int i)
        {
            if (i == 0)
            {
                for (int u = ingridients.Count - 1; u >= 0; u--)
                {
                    if (ingridients[u].isSelected == true)
                    {
                        ingridients.RemoveAt(u);
                    }
                }
            }
            if (i == 1)
            {
                for (int u = pizzaMain.Count - 1; u > 0; u--)
                {
                    if (pizzaMain[u].isSelected == true)
                    {
                        pizzaMain.RemoveAt(u);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isMakingPizza)
            {
                button1.Text = "Завершить сборку пиццы";
                StartMakingPizza();
            }
            else
            {
                StopMakingPizza();
            }
        }

        void StartMakingPizza()
        {
            isMakingPizza = true;
            for (int i = 0; i < ingridients.Count; i++)
            {
                ingridients[i].isSelected = false;
            }
            for (int i = 0; i < pizzaMain.Count; i++)
            {
                pizzaMain[i].isSelected = false;
            }
        }

        void StopMakingPizza()
        {
            if (!ValidatePizza())
            {
                MessageBox.Show("Вы не можете создать такую пиццу");
                goto a;
            }
            List<Ingridient> selectedIngredients = new List<Ingridient>();
            PizzaMain pizzaMains = new PizzaMain();
            for (int i = 0; i < ingridients.Count; i++)
            {
                if (ingridients[i].isSelected == true)
                {
                    selectedIngredients.Add(ingridients[i]);
                }
            }
            for (int i = 0; i < pizzaMain.Count; i++)
            {
                if (pizzaMain[i].isSelected == true)
                {
                    pizzaMains = pizzaMain[i];
                }
            }
            button1.Text = "Начать сборку пиццы";
            pizza.Add(new Pizza(selectedIngredients, pizzaMains));
            isMakingPizza = false;
        a:
            int gh = 0;
        }

        bool ValidatePizza()
        {
            int pizzaMainSel = 0;
            for (int i = 0; i < pizzaMain.Count; i++)
            {
                if (pizzaMain[i].isSelected == true)
                {
                    pizzaMainSel += 1;
                }
            }
            if (pizzaMainSel > 1 || pizzaMainSel == 0)
            {
                return false;
            }
            return true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "IsSelected")
            {
                dataGridView1.EndEdit();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isPizza)
            {
                OpenSecondGrid();
                int pizzaId = e.RowIndex;
                pizzaIdT = pizzaId;
                label4.Text = dataGridView1.Columns[e.ColumnIndex].Name;
                if (dataGridView1.Columns[e.ColumnIndex].Name == "ingredientsDisplay")
                {
                    changeWhat = 0;
                    ingridientsTemp = new BindingList<Ingridient>(ingridients);
                    sourceForAdd.DataSource = ingridientsTemp;
                    for (int i = 0; i < ingridientsTemp.Count; i++)
                    {
                        for (int u = 0; u < pizza[pizzaId].ingridientsPizza.Count; u++)
                        {
                            if (pizza[pizzaId].ingridientsPizza[u] == ingridientsTemp[i])
                            {
                                ingridientsTemp[i].isSelected = true;
                            }
                        }
                    }
                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "pizzaMainDisplay")
                {
                    changeWhat = 1;
                    pizzaMainTemp = new BindingList<PizzaMain>(pizzaMain);
                    sourceForAdd.DataSource = pizzaMainTemp;
                    for (int i = 0; i < pizzaMain.Count; i++)
                    {
                        if (pizza[pizzaId].pizzaMain == pizzaMain[i])
                        {
                            pizzaMain[i].isSelected = true;
                        }
                    }
                }
            }
        }

        void OpenSecondGrid()
        {
            dataGridView2.Visible = true;
            button2.Visible = true;
        }

        void CloseSecondGrid()
        {
            dataGridView2.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveChanges();
            CloseSecondGrid();
        }

        void SaveChanges()
        {
            if (changeWhat == 0)
            {
                List<Ingridient> temp = new List<Ingridient>();
                for (int i = 0; i < ingridients.Count; i++)
                {
                    if (ingridientsTemp[i].isSelected == true)
                    {
                        temp.Add(ingridientsTemp[i]);
                    }
                }
                pizza[pizzaIdT].AddIngredientsToPizza(temp);
            }
            if (changeWhat == 1)
            {
                PizzaMain temp = new PizzaMain();
                for (int i = 0; i < pizzaMainTemp.Count; i++)
                {
                    if (pizzaMainTemp[i].isSelected)
                    {
                        temp = pizzaMainTemp[i];
                        pizza[pizzaIdT].AddPizzaMainToPizza(temp);
                    }
                }
            }
        }
    }
}
 