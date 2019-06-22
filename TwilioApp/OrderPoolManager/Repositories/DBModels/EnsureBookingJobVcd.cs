using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("EnsureBookingJobVCD", Schema = "dbo")]
    public partial class EnsureBookingJobVcd
    {
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public int TotalCount { get; set; }
    }
}
