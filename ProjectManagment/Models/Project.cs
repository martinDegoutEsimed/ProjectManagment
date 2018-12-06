namespace ProjectManagment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Display(Name = "Name")]
        [StringLength(50)]
        public string name { get; set; }

        [Display(Name = "Trigram")]
        [StringLength(50)]
        public string trigram { get; set; }

        [Display(Name = "Accountant")]
        public int id_accountant { get; set; }

        [NotMapped]
        public List<Accountant> AccountantList { get; set; }

        [NotMapped]
        public string accountantName { get; set; }
    }
}
