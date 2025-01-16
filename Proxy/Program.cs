namespace Proxy
{
    public interface IFile
    {
        void Display();
    }

    public class PublicFile : IFile
    {
        public void Display()
        {
            Console.WriteLine("Wyświetlanie zawartości pliku publicznego.");
        }
    }

    public class ProtectedFile : IFile
    {
        public void Display()
        {
            Console.WriteLine("Wyświetlanie zawartości pliku zastrzeżonego.");
        }
    }

    public class FileProxy : IFile
    {
        private IFile _realFile;
        private readonly string _password;

        public FileProxy(IFile realFile, string password)
        {
            _realFile = realFile;
            _password = password;
        }

        public void Display()
        {
            Console.Write("Podaj hasło, aby uzyskać dostęp: ");
            string userInput = Console.ReadLine();

            if (userInput == _password)
            {
                _realFile.Display();
            }
            else
            {
                Console.WriteLine("Niepoprawne hasło. Dostęp zabroniony.");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IFile publicFile = new PublicFile();
            IFile protectedFile = new FileProxy(new ProtectedFile(), "secret123");

            while (true)
            {
                Console.WriteLine("\nWybierz plik do wyświetlenia:");
                Console.WriteLine("1. Plik publiczny");
                Console.WriteLine("2. Plik zastrzeżony");
                Console.WriteLine("0. Wyjście");

                Console.Write("Twój wybór: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        publicFile.Display();
                        break;
                    case "2":
                        protectedFile.Display();
                        break;
                    case "0":
                        Console.WriteLine("Koniec programu.");
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}
