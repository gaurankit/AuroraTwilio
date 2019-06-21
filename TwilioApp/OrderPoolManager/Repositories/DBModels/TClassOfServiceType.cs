using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tClassOfServiceType", Schema = "dbo")]
    public partial class TClassOfServiceType
    {
        public TClassOfServiceType()
        {
            TAirTicket = new HashSet<TAirTicket>();
            TClassOfServiceTypeCulture = new HashSet<TClassOfServiceTypeCulture>();
        }

        [Key]
        [Column("ClassOfServiceTypeID")]
        public int ClassOfServiceTypeId { get; set; }
        [Required]
        [StringLength(20)]
        public string ClassOfServiceType { get; set; }
        [Required]
        [StringLength(20)]
        public string OrderingToolClassOfServiceType { get; set; }

        [InverseProperty("ClassOfServiceType")]
        public ICollection<TAirTicket> TAirTicket { get; set; }
        [InverseProperty("ClassOfServiceType")]
        public ICollection<TClassOfServiceTypeCulture> TClassOfServiceTypeCulture { get; set; }
    }
}
