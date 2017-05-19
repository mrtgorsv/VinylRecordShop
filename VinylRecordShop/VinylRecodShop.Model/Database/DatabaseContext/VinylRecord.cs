//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VinylRecodShop.Model.Database.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class VinylRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<short> ReleaseYear { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public Nullable<int> PublisherId { get; set; }
        public string CountryCode { get; set; }
        public short VinylType { get; set; }
        public int Cost { get; set; }
        public Nullable<int> GenreId { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
