using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tPrimaryCruiseDestination", Schema = "dbo")]
    public partial class TPrimaryCruiseDestination
    {
        public TPrimaryCruiseDestination()
        {
            TCruise = new HashSet<TCruise>();
        }

        [Key]
        [Column("PrimaryCruiseDestinationID")]
        public int PrimaryCruiseDestinationId { get; set; }
        [Required]
        [StringLength(5)]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty("PrimaryCruiseDestination")]
        public ICollection<TCruise> TCruise { get; set; }
    }
}
