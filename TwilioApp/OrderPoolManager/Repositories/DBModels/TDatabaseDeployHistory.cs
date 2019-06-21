using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tDatabaseDeployHistory", Schema = "dbo")]
    public partial class TDatabaseDeployHistory
    {
        [Column("ID")]
        public long Id { get; set; }
        [StringLength(50)]
        public string DatabaseName { get; set; }
        [StringLength(100)]
        public string FolderName { get; set; }
        [StringLength(100)]
        public string FileName { get; set; }
        [StringLength(50)]
        public string CheckSum { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastCheckDateTime { get; set; }
    }
}
