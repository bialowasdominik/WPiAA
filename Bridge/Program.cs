namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System windowsSystemWithGraphic = new WindowsSystem(new GraphicInterface());
            System linuxSystemWithText = new LinuxSystem(new TextInterface());

            windowsSystemWithGraphic.ShowMenu();
            linuxSystemWithText.ShowMenu();
        }
    }
}
