using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familiada.Classes
{
    public class Answer
    {
        public Answer()
        {
            this.Name = string.Empty;
            this.Points = -1;
        }
        public string Name
        { get; set; }

        public int Points
        { get; set; }
    }
}
