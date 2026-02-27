using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public interface IFilterByText
    {
        bool Matches(string text);
    }

    public interface IFilterByPrice
    {
        int Price { get; }
    }

    public interface IFilterByDate
    {
        DateTime Date { get; }
    }

    public static class DataBase
    {
        public static BindingSource ingredientsSource = new BindingSource();
        public static BindingSource mainSource = new BindingSource();
        public static BindingSource pizzaSource = new BindingSource();
        public static BindingSource borderSource = new BindingSource();
        public static BindingSource orderSource = new BindingSource();
        public static BindingSource pizzaInOrderSource = new BindingSource();

        public static BindingList<Ingridient> ingridients = new BindingList<Ingridient>();
        public static BindingList<PizzaMain> pizzaMain = new BindingList<PizzaMain>();
        public static BindingList<Pizza> pizza = new BindingList<Pizza>();
        public static BindingList<Pizza> tempiPizzas = new BindingList<Pizza>();
        public static BindingList<Border> borders = new BindingList<Border>();
        public static BindingList<Order> orders = new BindingList<Order>();
        public static BindingList<PizzaInOrder> pizzasInOrder = new BindingList<PizzaInOrder>();

        public class BaseForAllWithNameAndPrice : IFilterByText, IFilterByPrice
        {
            public override string ToString()
            {
                return name ?? "";
            }
            protected string _name;
            public virtual string name
            {
                get { return _name; }
                set { _name = value; }
            }
            private int _price;
            [DisplayName("Цена в руб.")]
            public int price
            {
                get { return _price; }
                set { _price = value; }
            }
            [Browsable(false)]
            public int Price => price;
            public virtual bool Matches(string text)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    return true;
                }

                text = text.ToLower();
                return name?.ToLower().Contains(text) == true;
            }
        }

        public class Ingridient : BaseForAllWithNameAndPrice
        {
            [DisplayName("Ингредиент")]
            public override string name
            {
                get { return _name; }
                set { _name = value; }
            }
            public Ingridient() { }

            public Ingridient(string nameIngridient, int price)
            {
                this.name = nameIngridient;
                this.price = price;
            }
        }
        public class PizzaMain : BaseForAllWithNameAndPrice
        {
            [DisplayName("Тесто")]
            public override string name
            {
                get { return _name; }
                set { _name = value; }
            }

            public PizzaMain() { }

            public PizzaMain(string namePizzaMain, int price)
            {
                this.name = namePizzaMain;
                this.price = price;
            }
        }

        public static class FilterHelper
        {
            public static List<T> FilterByText<T>(IEnumerable<T> source, string text)
                where T : IFilterByText
                => source.Where(x => x.Matches(text)).ToList();

            public static List<T> FilterByPriceGreater<T>(IEnumerable<T> source, int min)
                where T : IFilterByPrice
                => source.Where(x => x.Price > min).ToList();

            public static List<T> FilterByPriceName<T>(IEnumerable<T> source, int min, string text)
                where T : IFilterByPrice , IFilterByText
                => source.Where(x => x.Price > min && x.Matches(text)).ToList();

            public static List<T> FilterByPriceLess<T>(IEnumerable<T> source, int max)
                where T : IFilterByPrice
                => source.Where(x => x.Price < max).ToList();

            public static List<T> FilterByDate<T>(IEnumerable<T> source, DateTime date)
                where T : IFilterByDate
                => source.Where(x => x.Date == date.Date).ToList();
        }

        public class Border : BaseForAllWithNameAndPrice
        {
            [DisplayName("Тип бортика")]
            public override string name
            {
                get { return _name; }
                set { _name = value; }
            }
            public Border(string namePizzaMain, int price)
            {
                this.name = namePizzaMain;
                this.price = price;
            }
            public Border() { }
        }

        public class PizzaInOrder
        {
            [DisplayName("Первая половинка")]
            public Pizza pizzaA { get; set; }
            [DisplayName("Вторая половинка")]
            public Pizza pizzaB { get; set; }
            [DisplayName("Удвоение ингредиентов")]
            public bool isDoubleIngredients { get; set; }
            [DisplayName("Бортик первой половинки")]
            public string nameBorderA { get { return borderA != null ? borderA.name : ""; } }
            [Browsable(false)]
            public Border borderA { get; set; }
            [DisplayName("Бортик второй половинки")]
            public string nameBorderB { get { return borderB != null ? borderB.name : ""; } }
            [Browsable(false)]
            public Border borderB { get; set; }
            [DisplayName("Тесто пиццы")]
            public PizzaMain pizzaMain { get; set; }
            [DisplayName("Размер пиццы")]
            public PizzaSize sizePizza { get; set; }
            [DisplayName("Количество пиццы")]
            public int countPizza { get; set; } = 1;
            [DisplayName("Цена пиццы")]
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
                int multiplier = (int)sizePizza + 1;
                int dopIngr = isDoubleIngredients ? pizzaA.ReturnIngredientsPrice() * 1 : 0;
                return basicPrice + dopIngr;
            }
            private int PriceChangeDouble()
            {
                int basicPrice = pizzaA.price + pizzaB.price;
                int multiplier = (int)sizePizza + 1;
                int dopIngrA = isDoubleIngredients ? pizzaA.ReturnIngredientsPrice() * 1 : 0;
                int dopIngrB = isDoubleIngredients ? pizzaB.ReturnIngredientsPrice() * 1 : 0;
                return basicPrice * multiplier + dopIngrA + dopIngrB;
            }
        }

        public class Order : IFilterByText, IFilterByDate, IFilterByPrice
        {
            [DisplayName("айди заказа")]
            public string idOrder { get; private set; } = Guid.NewGuid().ToString();
            [Browsable(false)]
            public List<PizzaInOrder> pizzas { get; set; } = new List<PizzaInOrder>();
            [DisplayName("Пиццы в заказе")]
            public string namePizzas
            {
                get
                {
                    string pizzasText = string.Join(", ",
                    pizzas.Select(po =>
                    {
                        string name = po.pizzaB == null
                        ? po.pizzaA.name
                        : $"{po.pizzaA.name} + {po.pizzaB.name}";
                        return $"{name} x{po.countPizza}";
                    }));
                    return pizzasText;
                }
            }
            [DisplayName("Сумма заказа")]
            public int priceOrder => pizzas.Sum(p => p.priceFor);
            [DisplayName("Комментарий")]
            public string comment { get; set; } = "";
            [DisplayName("Время заказа")]
            public DateTime timeOrder { get; set; } = DateTime.Now;
            [DisplayName("Отложенное время заказа")]
            public DateTime? delayed { get; set; }
            [Browsable(false)]
            public int Price => priceOrder;
            [Browsable(false)]
            public DateTime Date => timeOrder.Date;
            public bool Matches(string text)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    return true;
                }

                text = text.ToLower();
                return idOrder.ToString().Contains(text) || comment?.ToLower().Contains(text) == true || timeOrder.ToString("dd.MM.yyyy").Contains(text);
            }
        }

        public class Pizza : BaseForAllWithNameAndPrice
        {
            [DisplayName("Название пиццы")]
            public override string name
            {
                get { return _name; }
                set { _name = value; }
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
                        res += (res == "" ? "" : ", ") + ingredient.name;
                    }
                    return res;
                }
            }
            [DisplayName("Тесто")]
            public string pizzaMainDisplay
            {
                get
                {
                    return pizzasMain.name;
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
                    return pizzaBorder.name;
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

            public Pizza(string namePizza, List<Ingridient> ingridientsPizza, PizzaMain pizzasMain, Border pizzaBorder, List<Border> borderList)
            {
                this.name = namePizza;
                this.ingridientsPizza = ingridientsPizza;
                this.pizzasMain = pizzasMain;
                this.pizzaBorder = pizzaBorder;
                this.borderList = borderList;
            }
        }

        public enum PizzaSize
        {
            Маленькая = 0,
            Средняя = 1,
            Большая = 2,
        }
    }
}
