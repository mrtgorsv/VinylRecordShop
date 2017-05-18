using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecordShop.ViewModels.Base;

namespace VinylRecordShop.ViewModels.Publishers
{
    public class PublisherLightViewModel : DetailViewModelBase<Publisher>
    {
        public PublisherLightViewModel(Publisher publisher) : base(publisher)
        {
        }

        public string Name => Entity.Name;

        public int Id => Entity.Id;
    }
}