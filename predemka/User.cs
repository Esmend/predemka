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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Request = new HashSet<Request>();
        }
    
        public int idUser { get; set; }
        public string fioUser { get; set; }
        public string phoneUser { get; set; }
        public string loginUser { get; set; }
        public string passUser { get; set; }
        public Nullable<int> idRole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
        public virtual Role Role { get; set; }

        public User(string id, string fio, string phone, string login, string pass, string role)
        {
            this.idUser = int.Parse(id);
            this.fioUser = fio;
            this.phoneUser = phone;
            this.loginUser = login;
            this.passUser = pass;
            this.idRole = int.Parse(role);
        }
    }
}
