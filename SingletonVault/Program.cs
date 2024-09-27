namespace SingletonVault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vault1 = Vault.Instance;
            Console.WriteLine(vault1.getKey());

            var valut2 = Vault.Instance;
            Console.WriteLine(valut2.getKey());
        }
    }
}