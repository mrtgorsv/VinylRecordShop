using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecordShop.ViewModels.Base;

namespace VinylRecordShop.ViewModels.Authors
{
    public class AuthorLightViewModel : DetailViewModelBase<Author>
    {
        public AuthorLightViewModel(Author author): base(author)
        {
        }

        public int Id
        {
            get { return Entity.Id; }
        }

        public string Name
        {
            get { return Entity.Name; }
        }
    }
}
