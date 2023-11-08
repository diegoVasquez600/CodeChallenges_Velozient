namespace SmartVault.Program
{
    partial class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                return;
            }

            WriteEveryThirdFileToFile(args[0]);
            GetAllFileSizes();
        }

        private static void GetAllFileSizes()
        {
            // TODO: Implement functionality
        }

        private static void WriteEveryThirdFileToFile(string accountId)
        {
            // TODO: Implement functionality
        }
    }
}