//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Antipina_OlnineStickerStore.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ID_of_user { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middle_name { get; set; }
        public Nullable<System.DateTime> Date_of_birth { get; set; }
        public string Locality { get; set; }
        public string Address { get; set; }
        public Nullable<int> Number_phone { get; set; }
        public string E_mail { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
