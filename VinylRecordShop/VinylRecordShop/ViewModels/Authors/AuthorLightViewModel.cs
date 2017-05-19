using System.Windows.Controls;
using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecordShop.Pages.Author;
using VinylRecordShop.ViewModels.Base;

namespace VinylRecordShop.ViewModels.Authors
{
    public class AuthorLightViewModel : EntityViewModel<Author>
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

        protected override Page GetListPage()
        {
            throw new System.NotImplementedException();
        }
    }
}
