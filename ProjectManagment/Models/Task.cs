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

        public int taskId { get; set; }

        public int id_accountant { get; set; }

        [Column(TypeName = "date")]
        public DateTime scheduled_start_date { get; set; }

        public int work_load { get; set; }

        public int? required_taskID { get; set; }

        public int status { get; set; }

        [Column(TypeName = "date")]
        public DateTime real_start_date { get; set; }
    }
}
