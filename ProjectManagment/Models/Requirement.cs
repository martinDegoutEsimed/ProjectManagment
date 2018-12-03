namespace ProjectManagment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Requirement")]
    public partial class Requirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int reqId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string detail { get; set; }

        public int? type { get; set; }

        public int id_project { get; set; }
    }
}
