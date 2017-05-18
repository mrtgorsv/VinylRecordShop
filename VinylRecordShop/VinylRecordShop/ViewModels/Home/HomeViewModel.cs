namespace VinylRecordShop.ViewModels.Home
{
    public partial class HomeViewModel
    {
        private string _welocmeMessage;

        public string WelocmeMessage
        {
            get { return _welocmeMessage; }
            set { _welocmeMessage = value; }
        }

        public HomeViewModel()
        {
            WelocmeMessage = "Добро пожаловать в магазин виниловых пластинок";
        }
    }
}
