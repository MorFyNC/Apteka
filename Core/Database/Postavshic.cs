//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apteka.Core.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Postavshic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postavshic()
        {
            this.Dogovor_o_sotrudnichestve = new HashSet<Dogovor_o_sotrudnichestve>();
            this.Postavka = new HashSet<Postavka>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Id_adress { get; set; }
        public string INN { get; set; }
        public Nullable<int> kodOKPO { get; set; }
        public string Phone { get; set; }
        public string Contacts { get; set; }
    
        public virtual Adress Adress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dogovor_o_sotrudnichestve> Dogovor_o_sotrudnichestve { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Postavka> Postavka { get; set; }
    }
}
