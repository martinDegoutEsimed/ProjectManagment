using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagment
{
    public class Accountant
    {
        private int m_id;
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        private string m_name;
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public Accountant()
        {
            Console.WriteLine("A new accountant was added");
        }

        public Accountant(int id, string name)
        {
            this.m_id = id;
            this.m_name = name;
            Console.WriteLine("A new accountant was added. His name is " + name);
        }

        ~Accountant()
        {
            Console.WriteLine("An accountant was deleted");
        }
    }
}