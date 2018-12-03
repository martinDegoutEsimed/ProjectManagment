using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagment
{
    public class Task
    {
        private int m_id;
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        private int m_taskId;
        public int TaskId
        {
            get { return m_taskId; }
            set { m_taskId = value; }
        }

        private int m_id_accountant;
        public int Id_accountant
        {
            get { return m_id_accountant; }
            set { m_id_accountant = value; }
        }

        private DateTime m_scheduled_start_date;
        public DateTime Scheduled_start_date
        {
            get { return m_scheduled_start_date; }
            set { m_scheduled_start_date = value; }
        }

        private int m_work_load;
        public int Work_load
        {
            get { return m_work_load; }
            set { m_work_load = value; }
        }

        private int m_required_taskId;
        public int Required_taskId
        {
            get { return m_required_taskId; }
            set { m_required_taskId = value; }
        }

        private int m_status;
        public int Status
        {
            get { return m_status; }
            set { m_status = value; }
        }

        private DateTime m_real_start_date;
        public DateTime Real_start_date
        {
            get { return m_real_start_date; }
            set { m_real_start_date = value; }
        }

        public Task()
        {
            Console.WriteLine("A new task was added");
        }

        public Task(int id, int taskId, int id_accountant, DateTime scheduled_start_date, int work_load, int required_taskId, int status, DateTime real_start_date)
        {
            this.m_id = id;
            this.m_taskId = taskId;
            this.m_id_accountant = id_accountant;
            this.m_scheduled_start_date = scheduled_start_date;
            this.m_work_load = work_load;
            this.m_required_taskId = required_taskId;
            this.m_status = status;
            this.m_real_start_date = real_start_date;
            Console.WriteLine("A new task was added. Its id is " + taskId);
        }

        ~Task()
        {
            Console.WriteLine("A task was deleted");
        }
    }
}