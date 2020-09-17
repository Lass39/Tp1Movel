using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            var Id = EntryId.Text.ToString();
            var Pwr = EntryPassword.Text.ToString();

            if (Id == "admin" && Pwr == "senha@dmin")
            {
                DisplayAlert("Log in", "Sucesso!", "Voltar");
            }
            else
            {
                DisplayAlert("Log in", "Dados inválidos!", "Voltar");
            }
        }

        private void ButtonLimpar_Clicked(object sender, EventArgs e)
        {
            EntryId.Text = "";
            EntryPassword.Text = "";
            EntryId.Focus();
        }

        private void ButtonCréditos_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Giovanni Fernandes 1640488", "Voltar");
        }
    }
}
