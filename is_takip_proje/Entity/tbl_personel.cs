//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace is_takip_proje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_personel()
        {
            this.tbl_gorevler = new HashSet<tbl_gorevler>();
            this.tbl_gorevler1 = new HashSet<tbl_gorevler>();
        }
    
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Gorsel { get; set; }
        public Nullable<int> Departman { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual tbl_departmanlar tbl_departmanlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_gorevler> tbl_gorevler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_gorevler> tbl_gorevler1 { get; set; }
    }
}
