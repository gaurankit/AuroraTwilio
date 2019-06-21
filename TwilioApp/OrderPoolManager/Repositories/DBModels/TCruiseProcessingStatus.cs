using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCruiseProcessingStatus", Schema = "dbo")]
    public partial class TCruiseProcessingStatus
    {
        public TCruiseProcessingStatus()
        {
            TCruise = new HashSet<TCruise>();
        }

        [Key]
        [Column("CruiseProcessingStatusID")]
        public int CruiseProcessingStatusId { get; set; }
        [Required]
        [StringLength(20)]
        public string CruiseProcessingStatus { get; set; }

        [InverseProperty("CruiseProcessingStatus")]
        public ICollection<TCruise> TCruise { get; set; }
    }
}
