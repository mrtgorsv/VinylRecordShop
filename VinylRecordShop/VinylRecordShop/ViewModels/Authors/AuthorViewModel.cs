using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecordShop.Services.Services.Implementation;
using VinylRecordShop.ViewModels.Base;

namespace VinylRecordShop.ViewModels.Authors
{
    public class AuthorViewModel : EntityViewModel<Author>
    {

        public AuthorViewModel(int id): base(id , new AuthorService())
        {

        }
        public AuthorViewModel(Author entity): base(entity)
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

        public string CountryCode
        {
            get { return Entity.CountryCode; }
            set
            {
                Entity.CountryCode = value;
                OnPropertyChanged();
            }
        }
    }
}
