//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAM2017.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Submission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Submission()
        {
            this.ReviewPreferences = new HashSet<ReviewPreference>();
            this.Reviews = new HashSet<Review>();
        }
    
        public int Id { get; set; }
        public int SubmitterId { get; set; }
        public string FilePath { get; set; }
        public int DeadlineId { get; set; }
        public Nullable<double> Rating { get; set; }
        public string Title { get; set; }
    
        public virtual Deadline Deadline { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReviewPreference> ReviewPreferences { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual User User { get; set; }

        public bool CanReview()
        {
            throw new NotImplementedException();
        }
    }
}
