//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dershane_sistem.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenci()
        {
            this.Kasa = new HashSet<Kasa>();
            this.RehberOgretmen = new HashSet<RehberOgretmen>();
        }
    
        public int Ogrid { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public string OgrTc { get; set; }
        public string OgrTelefon { get; set; }
        public string OgrDogum { get; set; }
        public string OgrMail { get; set; }
        public string OgrVeliAdSoyad { get; set; }
        public string OgrVeliTelefon { get; set; }
        public string OgrVeliAdres { get; set; }
        public Nullable<int> OgrAlanid { get; set; }
        public Nullable<int> OgrSinifid { get; set; }
    
        public virtual Alanlar Alanlar { get; set; }
        public virtual Borclarr Borclarr { get; set; }
        public virtual Siniflar Siniflar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kasa> Kasa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RehberOgretmen> RehberOgretmen { get; set; }
    }
}