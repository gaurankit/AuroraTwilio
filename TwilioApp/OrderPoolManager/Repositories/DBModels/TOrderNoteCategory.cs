using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderNoteCategory", Schema = "dbo")]
    public partial class TOrderNoteCategory
    {
        public TOrderNoteCategory()
        {
            TOrderNote = new HashSet<TOrderNote>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Description { get; set; }
        public int DisplayOrder { get; set; }

        [InverseProperty("OrderNoteCategory")]
        public ICollection<TOrderNote> TOrderNote { get; set; }
    }
}
