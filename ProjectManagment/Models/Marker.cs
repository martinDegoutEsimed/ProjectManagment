namespace ProjectManagment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Marker")]
    public partial class Marker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Display(Name = "Label")]
        [Required]
        [StringLength(50)]
        public string label { get; set; }

        [Display(Name = "Best End Date")]
        [Column(TypeName = "date")]
        public DateTime best_end_date { get; set; }

        [Display(Name = "Accountant")]
        public int id_accountant { get; set; }

        [NotMapped]
        public List<Accountant> AccountantList { get; set; }

        [NotMapped]
        public string accountantName { get; set; }

        [Display(Name = "Real End Date")]
        [Column(TypeName = "date")]
        public DateTime? real_end_date { get; set; }
    }
}
