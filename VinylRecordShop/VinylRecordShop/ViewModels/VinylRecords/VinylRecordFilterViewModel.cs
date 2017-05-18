using System;
using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecordShop.ViewModels.Base;

namespace VinylRecordShop.ViewModels.VinylRecords
{
    public class VinylRecordFilterViewModel : ViewModelBase , IFilterViewModel<VinylRecord>
    {
        public string Name { get; set; }
        public string ReleaseYear { get; set; }

        public bool Filter(VinylRecord enity)
        {
            bool accepted = true;

            if (!string.IsNullOrWhiteSpace(Name))
            {
                accepted = enity.Name.Contains(Name);
            }
            if (!string.IsNullOrWhiteSpace(ReleaseYear))
            {
                accepted = enity.Name.Contains(ReleaseYear);
            }
            return accepted;
        }
    }
}