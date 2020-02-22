using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Trainee
    {
        private int  trainee_id;
        private string trainee_name;
        private int project_id;
       
        public int Trainee_id { get => trainee_id; set => trainee_id = value; }
        public string Trainee_name { get => trainee_name; set => trainee_name = value; }
        public int Project_id { get => project_id; set => project_id = value; }
        public Trainee(int trainee_id,string trainee_name,int project_id)
        {
            this.trainee_id = trainee_id;
            this.trainee_name = trainee_name;
            this.project_id = project_id;
        }
        public override string ToString()
        {
            return this.trainee_name;
        }
    }
}
