using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagment
{
    public class Requirement
    {
        private int m_id;
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        private int m_reqId;
        public int ReqId
        {
            get { return m_reqId; }
            set { m_reqId = value; }
        }

        private string m_detail;
        public string Detail
        {
            get { return m_detail; }
            set { m_detail = value; }
        }

        private int m_type;
        public int Type
        {
            get { return m_type; }
            set { m_type = value; }
        }

        private int m_id_project;
        public int Id_project
        {
            get { return m_id_project; }
            set { m_id_project = value; }
        }

        public Requirement()
        {
            Console.WriteLine("A new requirement was added");
        }

        public Requirement(int id, int reqId, string detail, int type, int id_project)
        {
            this.m_id = id;
            this.m_reqId = reqId;
            this.m_detail = detail;
            this.m_type = type;
            this.m_id_project = id_project;
            Console.WriteLine("A new requirement was added. Its id is " + reqId);
        }

        ~Requirement()
        {
            Console.WriteLine("A requirement was deleted");
        }
    }
}