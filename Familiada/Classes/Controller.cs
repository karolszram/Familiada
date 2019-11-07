using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familiada.Classes
{
    class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance != null) return instance;
                instance = new Controller();
                return instance;
            }
        }
    }
}
