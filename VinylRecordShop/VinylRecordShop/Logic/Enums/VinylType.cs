using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VinylRecordShop.Logic.Enums
{
    public enum VinylType
    {
        [Display(Name = "Долгоиграющая")]
        Lp = 0,

        [Display(Name = "Маленькая")]
        Sp = 1
    }
}