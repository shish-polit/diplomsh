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
    
    public partial class ReservationServices
    {
        public int ID { get; set; }
        public Nullable<int> ReservationID { get; set; }
        public Nullable<int> ServicesID { get; set; }
    
        public virtual Reservation Reservation { get; set; }
        public virtual Services Services { get; set; }
    }
}