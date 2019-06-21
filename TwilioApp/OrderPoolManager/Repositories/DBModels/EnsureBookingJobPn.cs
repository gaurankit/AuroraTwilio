using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("EnsureBookingJobPN", Schema = "dbo")]
    public partial class EnsureBookingJobPn
    {
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [StringLength(200)]
        public string TravelPlanName { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
