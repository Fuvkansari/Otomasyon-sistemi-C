//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TUrun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TUrun()
        {
            this.TSatis = new HashSet<TSatis>();
        }
    
        public string UrunKodu { get; set; }
        public string UrunAd { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
        public Nullable<int> Kategori { get; set; }
        public Nullable<int> Stok { get; set; }
        public Nullable<decimal> AlisFiyat { get; set; }
    
        public virtual TKategori TKategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSatis> TSatis { get; set; }
    }
}
