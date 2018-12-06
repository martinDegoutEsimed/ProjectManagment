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

        [Display(Name = "Requirement ID")]
        public string reqId { get; set; }

        [Display(Name = "Detail")]
        [Column(TypeName = "text")]
        [Required]
        public string detail { get; set; }

        [Display(Name = "Type")]
        public string type { get; set; }

        [Display(Name = "Project")]
        public int id_project { get; set; }

        [NotMapped]
        public List<Project> ProjectList { get; set; }

        [NotMapped]
        public string projectName { get; set; }

        [Display(Name = "Task")]
        public int task_ID { get; set; }

        [NotMapped]
        public List<Task> TaskList { get; set; }

        [NotMapped]
        public string taskIdentifier { get; set; }
    }
}