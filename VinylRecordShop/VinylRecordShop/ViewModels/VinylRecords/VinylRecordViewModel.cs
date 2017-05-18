using System.Collections.Generic;
using System.Linq;
using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecordShop.Services.Services.Implementation;
using VinylRecordShop.ViewModels.Authors;
using VinylRecordShop.ViewModels.Base;
using VinylRecordShop.ViewModels.Publishers;

namespace VinylRecordShop.ViewModels.VinylRecords
{
    public class VinylRecordViewModel : EntityViewModel<VinylRecord>
    {
        private readonly AuthorService _authorService = new AuthorService();
        private readonly PublisherService _publisherService= new PublisherService();

        public VinylRecordViewModel(int id): base(id , new VinylRecordService())
        {
            
        }

        public VinylRecordViewModel(VinylRecord entity): base(entity)
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

        public short? ReleaseYear
        {
            get { return Entity.ReleaseYear; }
            set
            {
                Entity.ReleaseYear = value;
                OnPropertyChanged();
            }
        }

        public int Cost
        {
            get { return Entity.Cost; }
            set
            {
                Entity.Cost = value;
                OnPropertyChanged();
            }
        }

        public short VinylType
        {
            get { return Entity.VinylType; }
            set
            {
                Entity.VinylType = value;
                OnPropertyChanged();
            }
        }

        //TODO : implement
        public int? GenreId
        {
            get { return null; }
            set
            {
                OnPropertyChanged();
            }
        }
        //TODO : implement
        public string GenreName
        {
            get { return string.Empty; }
        }

        public string VinylTypeName
        {
            get { return ((Logic.Enums.VinylType)Entity.VinylType).ToString(); }
        }

        public int AuthorId
        {
            get { return Entity.AuthorId ?? 0; }
            set
            {
                Entity.AuthorId = value;
                OnPropertyChanged();
            }
        }

        public int PublisherId
        {
            get { return Entity.PublisherId ?? 0; }
            set
            {
                Entity.PublisherId = value;
                OnPropertyChanged();
            }
        }

        public string AuthorName
        {
            get { return Entity.AuthorId > 0 ? Entity.Author.Name : string.Empty; }
        }

        public string PublisherName
        {
            get { return Entity.PublisherId > 0 ? Entity.Publisher.Name : string.Empty; }
        }

        public List<AuthorLightViewModel> AuthorList
        {
            get { return _authorService.GetAll().Select(a => new AuthorLightViewModel(a)).ToList(); }
        }

        public List<PublisherLightViewModel> PublisherList
        {
            get { return _publisherService.GetAll().Select(p => new PublisherLightViewModel(p)).ToList(); }
        }
    }
}