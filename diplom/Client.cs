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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Reservation = new HashSet<Reservation>();
        }
    
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public Nullable<System.DateTime> Dateofbirth { get; set; }
        public string Town { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string Passport { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservation { get; set; }

        public string FullName { get => $"{Firstname} {Name} {Middlename}"; }
    }
}