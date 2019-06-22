using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tADAgentInformation", Schema = "dbo")]
    public partial class TAdagentInformation
    {
        [Key]
        [Column("ADAgentInformationID")]
        public int AdagentInformationId { get; set; }
        [Required]
        [StringLength(500)]
        public string CreatedByName { get; set; }
        [StringLength(20)]
        public string OrderCreatedBy { get; set; }
        [StringLength(100)]
        public string Location { get; set; }
        [Required]
        [Column("ADInfo")]
        [StringLength(4000)]
        public string Adinfo { get; set; }
        [Required]
        [Column("TravcomID")]
        [StringLength(20)]
        public string TravcomId { get; set; }
    }
}
