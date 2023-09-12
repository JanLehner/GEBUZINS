namespace GebuZins
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Dataprocessor dataprocessor = new Dataprocessor();
            Datachecker checker = new Datachecker();
            Application.Run(new Form2(dataprocessor, checker));
        }
    }
}