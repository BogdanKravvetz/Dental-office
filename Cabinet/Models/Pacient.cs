//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cabinet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pacient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pacient()
        {
            this.Programare = new HashSet<Programare>();
        }
    
        public int idPacient { get; set; }
        public int idUtilizator { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string cnp { get; set; }
        public bool isDeleted { get; set; }
    
        public virtual Utilizator Utilizator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programare> Programare { get; set; }
    }
}
