using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecordShop.Services.Services.Implementation;
using VinylRecordShop.ViewModels.Base;

namespace VinylRecordShop.ViewModels.VinylRecords
{
    public class VinylRecordListViewModel : ListViewModelBase<VinylRecord>
    {
        public VinylRecordListViewModel() : base(new VinylRecordService())
        {
        }
    }
}
