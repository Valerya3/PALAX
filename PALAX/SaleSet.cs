//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PALAX
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleSet
    {
        public int ID { get; set; }
        public System.DateTime Data { get; set; }
        public Nullable<int> IDStaff { get; set; }
        public Nullable<int> IDClientsFiz { get; set; }
        public Nullable<int> IDClientsYour { get; set; }
        public Nullable<long> Prise { get; set; }
    
        public virtual ClientsFizSet ClientsFizSet { get; set; }
        public virtual ClientsYourSet ClientsYourSet { get; set; }
        public virtual StaffSet StaffSet { get; set; }
    }
}
