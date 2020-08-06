using Rave.Models.Charge;
using Rave.NET.Models.Card;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace FlutterRaveCard
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

        private async void PayBtn_Clicked(object sender, EventArgs e)
        {
            var cardCharge = new ChargeCard(Helper.raveConfig);
            var Payload = new CardParams(Helper.PbKey, "Anonymous", "Customer", "tester@example.com", 2100) { CardNo = "5438898014560229", Cvv = "789", Expirymonth = "09", Expiryyear = "19", TxRef = "Tr672yR"};

            await Navigation.PushAsync(new AddPinPay());
        }
    }
}
