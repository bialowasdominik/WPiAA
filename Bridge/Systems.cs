namespace Bridge
{
    public abstract class System
    {
        protected IInterface _interface;

        public System(IInterface systemInterface)
        {
            _interface = systemInterface;
        }

        public abstract void ShowMenu();
    }

    public class WindowsSystem : System
    {
        public WindowsSystem(IInterface systemInterface) : base(systemInterface) { }

        public override void ShowMenu()
        {
            Console.WriteLine("Windows: Displaying menu");
            _interface.DisplayMenu();
        }
    }

    public class LinuxSystem : System
    {
        public LinuxSystem(IInterface systemInterface) : base(systemInterface) { }

        public override void ShowMenu()
        {
            Console.WriteLine("Linux: Displaying menu");
            _interface.DisplayMenu();
        }
    }
}
