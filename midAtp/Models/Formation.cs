//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace db.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Formation
    {
        public int id { get; set; }
        [Required (AllowEmptyStrings = false, ErrorMessage = "Name is Rrquired. ")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Fromation Type is Rrquired. ")]
        public string Type { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Date is Rrquired. ")]
        public System.DateTime Date { get; set; }
    }
}
