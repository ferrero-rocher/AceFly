//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AceFly.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_details()
        {
            this.Tickets = new HashSet<Ticket>();
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int Id { get; set; }
        public string email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }
        public long Phoneno { get; set; }
        public System.DateTime DOB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
