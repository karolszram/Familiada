using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Familiada.Classes
{
    public class QuestionsCtrl
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
        
        public bool SaveXml(List<Question> questions, out string msg, string Filename = "pytania.xml")
        {
            msg = string.Empty;
            if(string.IsNullOrEmpty(Filename))
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

            try
            {
                var serializer = new XmlSerializer(typeof(List<Question>));

                File.Delete(Filename);
                using (var stream = File.OpenWrite(Filename))
                    serializer.Serialize(stream, questions);

            }
            catch(Exception e)
            {
                msg = e.Message;
                return false;
            }
            return true;
        }

        public bool LoadXml(out List<Question> list, out string msg, string Filename = "pytania.xml")
        {
            msg = string.Empty;
            list = new List<Question>();

            if(string.IsNullOrEmpty(Filename))
            {
                msg = "Filename is null or empty";
                return false;
            }


            XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
            try
            {
                using (var stream = File.OpenRead(Filename))
                {
                    foreach (Question q in (List<Question>)serializer.Deserialize(stream))
                        list.Add(q);
                }
            }

            catch(Exception e)
            {
                msg = e.Message;
                return false;
            }

            return true;
        }
    }
}
