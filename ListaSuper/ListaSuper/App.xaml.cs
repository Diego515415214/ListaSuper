using ListaSuper.Datos;
using ListaSuper.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaSuper
{
    public partial class App : Application
    {

        public static DatabaseContext Context { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeDatabase();
            MainPage = new NavigationPage(new HomePage());
        }

        private void InitializeDatabase()
        {
         
            var folderApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbPath = System.IO.Path.Combine(folderApp, "Lista.db3");
            Context = new DatabaseContext(dbPath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
