using System.DirectoryServices;
using TinyGamesStore.InMemory;
using TinyGameStore.Data;

namespace TinyGameStore_G2
{
    internal static class Program
    {
        public static Form Store { get; set; } = new frmStore();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
       
        [STAThread]
        static void Main()
        {
            /*
             * Todo: Authenticate move to DB
             * Move filling data to DB ctor()
             * 
             * 
             */
            InitializeInMemoryDB();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            
            Application.Run(new frmLogin());
            //Application.Run(Store); 
           

            

        }

        private static void InitializeInMemoryDB()
        {
            User amel = new User()
            {
                UserName = "Amel",
                Password = "fit123"
            };
            User adin = new User()
            {
                UserName = "Adin",
                Password = "rtx4090"
            };
            User adis = new User()
            {
                UserName = "Adis",
                Password = "foureyes\\"
            };

            InMemoryDB.TryAdd(amel);
            InMemoryDB.TryAdd(adin);
            InMemoryDB.TryAdd(adis);
        }
    }
}