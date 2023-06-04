namespace rtipo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new Context()) { }

            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm());

        }
    }
}