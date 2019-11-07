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
            this.Answer = new List<Answer>();
        }

        public string Name
        { get; set; }

        public List<Answer> Answer
        { get; set; }

    }
}
