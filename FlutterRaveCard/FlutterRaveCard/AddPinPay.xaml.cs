using FlutterRaveCard.Models.Card;
using Rave;
using Rave.NET.Models.Charge;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlutterRaveCard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPinPay : ContentPage
    {
        private static string PbKey = "pass your public key here";
        private static string tranxRef = "454839";
        private static string ScKey = "pass your secret key here";
        RaveConfig raveConfig = new RaveConfig(PbKey, ScKey, false);
        public AddPinPay()
        {
            InitializeComponent();
        }


        private void Btn_Clicked(object sender, EventArgs e)
        {
            //DependencyService.Get<IMessage>().ShortAlert("Image downloaded");
            DependencyService.Get<IMessage>().LongAlert("Image Uploaded");
        }

            static void Main(string[] args)
            {

                var raveConfig = new RaveConfig(PbKey, ScKey, false);
            var cardCharge = new ChargeCard(Helper.raveConfig);
            var cardParams = new CardParams();

            var Payload = new CardParams(PbKey, "Anonymous", "Customer", "tester@example.com", 2100)
                { CardNo = "5438898014560229", Cvv = "789", Expirymonth = "09", Expiryyear = "19", TxRef = tranxRef };
                var cha = cardCharge.Charge(cardParams).Result;


                if (cha.Message == "AUTH_SUGGESTION" && cha.Data.SuggestedAuth == "PIN")
                {
                    cardParams.Pin = "3310";
                    cardParams.Otp = "12345";
                    cardParams.SuggestedAuth = "PIN";
                    cha = cardCharge.Charge(Payload).Result;
                }


            }
    }
}