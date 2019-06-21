using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tShippingStatusType", Schema = "dbo")]
    public partial class TShippingStatusType
    {
        public TShippingStatusType()
        {
            TShipping = new HashSet<TShipping>();
        }

        [Key]
        [Column("ShippingStatusTypeID")]
        public int ShippingStatusTypeId { get; set; }
        [Required]
        [StringLength(20)]
        public string ShippingStatusType { get; set; }

        [InverseProperty("ShippingStatusType")]
        public ICollection<TShipping> TShipping { get; set; }
    }
}
