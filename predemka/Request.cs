//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace predemka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int idRequest { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<int> idTypeCar { get; set; }
        public string carModel { get; set; }
        public string problemDes { get; set; }
        public string requestStatus { get; set; }
        public Nullable<System.DateTime> compliteDate { get; set; }
        public string repairParts { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> idMaster { get; set; }
    
        public virtual TypeCar TypeCar { get; set; }
        public virtual User User { get; set; }
    }
}