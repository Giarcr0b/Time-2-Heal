using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeToHeal
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnInfoButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }

        public async void OnChatButtonClicked(Object sender, EventArgs e)
        {
           
        }

        public async void OnHelpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpPage());
        }

        
    }
}
