﻿

namespace OperacionesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Ejercicios.Operaciones.MainPage();
        }
    }
}