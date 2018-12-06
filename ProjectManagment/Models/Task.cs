namespace ProjectManagment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Display(Name = "Task Id")]
        public string taskId { get; set; }

        [Display(Name = "Accountant")]
        public int id_accountant { get; set; }

        [NotMapped]
        public List<Accountant> AccountantList { get; set; }

        [NotMapped]
        public string accountantName { get; set; }

        [Display(Name = "Scheduled Start Date")]
        [Column(TypeName = "date")]
        public DateTime scheduled_start_date { get; set; }

        [Display(Name = "Work Load (Man Hours)")]
        public int work_load { get; set; }

        [Display(Name = "Previous Task Id")]
        public int? required_taskID { get; set; }

        [Display(Name = "Status")]
        public string status { get; set; }

        [Display(Name = "Real Start Date")]
        [Column(TypeName = "date")]
        public DateTime real_start_date { get; set; }
    }
}
