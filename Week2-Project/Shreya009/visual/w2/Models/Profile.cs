//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace w2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile
    {
        public int ID { get; set; }
        public string Designation { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
    
        public virtual SignUp SignUp { get; set; }
    }
}
