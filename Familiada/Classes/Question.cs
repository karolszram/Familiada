using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familiada.Classes
{
    public class Question
    {

        public Question()
        {
            this.Name = string.Empty;
            this.Answers = new List<Answer>();
        }

        //public int Id
        //{ get; set; }

        public string Name
        { get; set; }

        public List<Answer> Answers
        { get; set; }

    }
}
