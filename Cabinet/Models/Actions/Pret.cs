//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cabinet.Models.Actions
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pret
    {
        public int idPret { get; set; }
        public int idInterventie { get; set; }
        public Nullable<System.DateTime> dataInceput { get; set; }
        public Nullable<System.DateTime> dataSfarsit { get; set; }
        public Nullable<decimal> pret1 { get; set; }
        public bool isDeleted { get; set; }
    
        public virtual Interventie Interventie { get; set; }
    }
}
