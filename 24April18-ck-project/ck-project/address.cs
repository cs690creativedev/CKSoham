
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ck_project
{

using System;
    using System.Collections.Generic;
    
public partial class address
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public address()
    {

        this.branches = new HashSet<branch>();

        this.customers = new HashSet<customer>();

    }


    public int address_number { get; set; }

    public string address_type { get; set; }

    public string address1 { get; set; }

    public string city { get; set; }

    public string state { get; set; }

    public string county { get; set; }

    public string zipcode { get; set; }

    public bool deleted { get; set; }

    public Nullable<int> lead_number { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<branch> branches { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<customer> customers { get; set; }

}

}