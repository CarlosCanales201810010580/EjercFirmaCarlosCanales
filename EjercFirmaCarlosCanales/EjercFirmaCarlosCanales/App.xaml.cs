using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EjercFirmaCarlosCanales.models;
using EjercFirmaCarlosCanales.controller;
using System.IO;

namespace EjercFirmaCarlosCanales
{
    public partial class App : Application
    {
        static dbfirma dbbases;

        public static dbfirma Basedb
        {
            get
            {
                if (dbbases == null)
                {
                    dbbases = new dbfirma(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FirmasDB.db3"));
                }
                return dbbases;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
