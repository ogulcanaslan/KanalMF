//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KanalMF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yayin
    {
        public Yayin()
        {
            this.Sorumlu = new HashSet<Sorumlu>();
        }
    
        public int YayinId { get; set; }
        public string YAdi { get; set; }
        public string YTarihi { get; set; }
        public decimal YReyting { get; set; }
        public int KanalKanalId { get; set; }
    
        public virtual Kanal Kanal { get; set; }
        public virtual ICollection<Sorumlu> Sorumlu { get; set; }
    }
}