//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmsLab2
{
    using System;
    using System.Collections.Generic;
    
    public partial class FilmsActor
    {
        public int fa_id { get; set; }
        public int fa_f_id { get; set; }
        public int fa_a_id { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual Film Film { get; set; }
    }
}