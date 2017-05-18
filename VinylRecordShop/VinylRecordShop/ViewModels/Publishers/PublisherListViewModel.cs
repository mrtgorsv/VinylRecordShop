﻿using System.Windows.Controls;
using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecordShop.Pages.Publisher;
using VinylRecordShop.Services.Services.Implementation;
using VinylRecordShop.ViewModels.Base;

namespace VinylRecordShop.ViewModels.Publishers
{
    public class PublisherListViewModel : ListViewModelBase<Publisher>
    {
        public PublisherListViewModel() : base(new PublisherService())
        {
        }

        protected override Page GetDetailPage(int entityId = 0)
        {
            return new PublisherDetailsPage(new PublisherViewModel(entityId));
        }
    }
}