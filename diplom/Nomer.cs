//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace diplom
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nomer()
        {
            this.Reservation = new HashSet<Reservation>();
        }
    
        public int ID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string KolvoSpace { get; set; }
        public Nullable<int> PersonnelID { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Personnel Personnel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
