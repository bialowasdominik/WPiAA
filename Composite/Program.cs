namespace Composite
{
    public interface IMenuComponent
    {
        void DisplayMenu(int indentLevel);
    }

    public class Dish : IMenuComponent
    {
        private string _name;
        private decimal _price;

        public Dish(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public void DisplayMenu(int indentLevel)
        {
            Console.WriteLine(new string(' ', indentLevel * 2) + _name + " - " + _price.ToString("C"));
        }
    }

    public class MenuCategory : IMenuComponent
    {
        private string _name;
        private List<IMenuComponent> _menuComponents;

        public MenuCategory(string name)
        {
            _name = name;
            _menuComponents = new List<IMenuComponent>();
        }

        public void Add(IMenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public void DisplayMenu(int indentLevel)
        {
            Console.WriteLine(new string(' ', indentLevel * 2) + _name + ":");

            foreach (var component in _menuComponents)
            {
                component.DisplayMenu(indentLevel + 1);
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            IMenuComponent pizza = new Dish("Pizza Margherita", 19.99m);
            IMenuComponent pasta = new Dish("Spaghetti Carbonara", 22.50m);
            IMenuComponent steak = new Dish("Ribeye Steak", 29.99m);
            IMenuComponent soup = new Dish("Tomato Soup", 12.99m);

            MenuCategory appetizers = new MenuCategory("Appetizers");
            appetizers.Add(soup);

            MenuCategory mainCourse = new MenuCategory("Main Course");
            mainCourse.Add(pizza);
            mainCourse.Add(pasta);
            mainCourse.Add(steak);

            MenuCategory menu = new MenuCategory("Restaurant Menu");
            menu.Add(appetizers);
            menu.Add(mainCourse);

            menu.DisplayMenu(0);
        }
    }
}
