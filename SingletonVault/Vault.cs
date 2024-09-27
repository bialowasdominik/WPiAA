namespace SingletonVault
{
    public sealed class Vault
    {
        private static Vault vault;
        private static string key;
        private static object syncRoot = new Object();
        private Vault()
        {
            key = generateKey();
        }

        public static Vault Instance
        {
            get
            {
                lock (syncRoot)
                {
                    if (vault == null)
                    {
                        vault = new Vault();
                    }
                }

                return vault;
            }
        }

        public string getKey()
        {
            return key;
        }

        private string generateKey() 
        {
            return Guid.NewGuid().ToString();
        }
    }
}
