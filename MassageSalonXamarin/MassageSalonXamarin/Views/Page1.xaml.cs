using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MassageSalonXamarin.Models;

namespace MassageSalonXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        
        public Page1()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            updatelist();
            base.OnAppearing();
        }
        public void updatelist()
        {
            using (SalonMassagaContext db = new SalonMassagaContext())
            {
                var ShiftList = db.Workers.ToList();
                ListShift.ItemsSource = ShiftList;
            }
        }
    }
}