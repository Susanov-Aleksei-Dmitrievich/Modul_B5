//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UchetOborudovania.BaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sotrudniki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sotrudniki()
        {
            this.IstoriaVhoda = new HashSet<IstoriaVhoda>();
            this.Oborudovanie = new HashSet<Oborudovanie>();
            this.SotrudnikiOfRucovoditeli = new HashSet<SotrudnikiOfRucovoditeli>();
        }
    
        public int IdSotrudnika { get; set; }
        public string FIO { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public long NomerTelefona { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IstoriaVhoda> IstoriaVhoda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oborudovanie> Oborudovanie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SotrudnikiOfRucovoditeli> SotrudnikiOfRucovoditeli { get; set; }
    }
}
