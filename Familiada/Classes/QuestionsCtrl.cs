using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familiada.Classes
{
    class QuestionsCtrl
    {
        private static QuestionsCtrl instance; 
        public static QuestionsCtrl Instance
        {
            get
            {
                if (instance != null) return instance;
                instance = new QuestionsCtrl();
                return instance;
            }
        }

        public bool SaveXml(string filename, List<Question> questions, out string msg)
        {
            msg = string.Empty;
            if(string.IsNullOrEmpty(filename))
            {
                msg = "Filename is null or empty";
                return false;
            }
            if(questions == null)
            {
                msg = "Questions list is null";
                return false;
            }
            if (questions.Count() == 0)
            {
                msg = "Questions list is empty";
                return false;
            }



            return true;

        }

    }
}
