using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagment
{
    public class Project
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

        private string m_trigram;
        public string Trigram
        {
            get { return m_trigram; }
            set { m_trigram = value; }
        }

        public Project()
        {
            Console.WriteLine("A new project was added");
        }

        public Project(int id, string name, string trigram)
        {
            this.m_id = id;
            this.m_name = name;
            this.m_trigram = trigram;
            Console.WriteLine("A new project was added. It is called " + name + " and its trigram is " + trigram);
        }

        ~Project()
        {
            Console.WriteLine("A project was deleted");
        }
    }
}