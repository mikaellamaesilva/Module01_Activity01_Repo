using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PDC60_MOD1_ACT1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CreateCommand = new Command<Type>((Type viewType) =>

            {
                View view = (View)Activator.CreateInstance(viewType);
                view.VerticalOptions = LayoutOptions.Center;
                view.BackgroundColor = Color.FromHex("#faeba7");
                view.WidthRequest = 50;
                view.HeightRequest = 80;
                view.Margin = new Thickness (30,0,30,10);

                stackLayout.Children.Add(view);
            });
            BindingContext = this;
        }

        public ICommand CreateCommand { private set; get; }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            var value = args.NewValue.ToString("0");
            valueLabel.Text = String.Format("Rate how much you like Xamarin : {0}", value);

        }


    }
    
}
