namespace ProjectManagment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marker")]
    public partial class Marker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string label { get; set; }

        [Column(TypeName = "date")]
        public DateTime best_end_date { get; set; }

        public int id_accountant { get; set; }

        [Column(TypeName = "date")]
        public DateTime? real_end_date { get; set; }
    }
}
