using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagment
{
    public class Marker
    {
        private int m_id;
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        private string m_label;
        public string Label
        {
            get { return m_label; }
            set { m_label = value; }
        }

        private DateTime m_best_end_date;
        public DateTime Best_end_date
        {
            get { return m_best_end_date; }
            set { m_best_end_date = value; }
        }

        private int m_id_accountant;
        public int Id_accountant
        {
            get { return m_id_accountant; }
            set { m_id_accountant = value; }
        }

        private DateTime m_real_end_date;
        public DateTime Real_end_date
        {
            get { return m_real_end_date; }
            set { m_real_end_date = value; }
        }

        public Marker()
        {
            Console.WriteLine("A new marker was added");
        }

        public Marker(int id, string label, DateTime best_end_date, int id_accountant, DateTime real_end_date)
        {
            this.m_id = id;
            this.m_label = label;
            this.m_best_end_date = best_end_date;
            this.m_id_accountant = id_accountant;
            this.m_real_end_date = real_end_date;
            Console.WriteLine("A new marker was added. Its name is " + label);
        }

        ~Marker()
        {
            Console.WriteLine("A marker was deleted");
        }
    }
}