using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazorApp.Services
{
    public class AlertService
    {
        public async Task alert(string title, string message)
        {
            await App.Current.MainPage.DisplayAlert(title, message, "Cancel");
        }

        public async Task<bool> confirmation(string title, string message)
        {
          bool exit = await App.Current.MainPage.DisplayAlert(title, message, "Yes","No");
            return exit;
        }
    }
}
