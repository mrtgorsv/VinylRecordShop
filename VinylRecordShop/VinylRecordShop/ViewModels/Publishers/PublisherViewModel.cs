using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecordShop.Services.Services.Implementation;
using VinylRecordShop.ViewModels.Base;

namespace VinylRecordShop.ViewModels.Publishers
{
    public class PublisherViewModel : EntityViewModel<Publisher>
    {
        public PublisherViewModel(int id): base(id , new PublisherService())
        {

        }

        public PublisherViewModel(Publisher entity) : base(entity)
        {

        }

        public string Name
        {
            get { return Entity.Name; }
            set
            {
                Entity.Name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return Entity.Description; }
            set
            {
                Entity.Description = value;
                OnPropertyChanged();
            }
        }
    }
}