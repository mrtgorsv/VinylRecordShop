//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VinylRecodShop.Model.Database.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class EntityEventLog
    {
        public int Id { get; set; }
        public short ActionType { get; set; }
        public string EntityJson { get; set; }
        public System.DateTime ActionDate { get; set; }
        public Nullable<int> EntityId { get; set; }
        public string EntityType { get; set; }
    }
}