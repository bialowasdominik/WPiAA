namespace DuplicatedCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            logger.LogWarning("warrning message without duplicating code", DateTime.Now);
            logger.LogError("error message without duplicating code", DateTime.Now);
        }
    }
}