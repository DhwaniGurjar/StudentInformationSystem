//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIS_DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCity
    {
        public tblCity()
        {
            this.tblCollege = new HashSet<tblCollege>();
        }
    
        public System.Guid ID { get; set; }
        public string CityName { get; set; }
        public Nullable<System.Guid> StateID { get; set; }
    
        public virtual tblState tblState { get; set; }
        public virtual ICollection<tblCollege> tblCollege { get; set; }
    }
}
