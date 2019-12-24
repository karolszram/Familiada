using System;
using System.Collections.Generic;
using System.IO;
using Familiada.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void data()
        {
            var x = File.GetLastWriteTime("Familiada.exe")- DateTime.Today;
        }


        [TestMethod]
        public void LoadDataFromXml()
        {
            List<Question> questions = new List<Question>();
            //bool success = QuestionsCtrl.Instance.LoadXml(out questions, out string msg);

            //Assert.IsTrue(success);
        }

        [TestMethod]
        public void SaveDataToXml()
        {
            List<Question> list = new List<Question>();

            Question q1 = new Question { Name = "Wymień święto kościelne" };
            List<Answer> a1 = new List<Answer>{
                new Answer{Name="Miś",Points = 4 },
                new Answer{Name="Seksmisja",Points = 14 },
                new Answer{Name="Killer",Points = 6},
                new Answer{Name="Chłopaki nie płaczą",Points = 24 },
                new Answer{Name="Zróbmy sobie wnuka",Points = 3 }
                };
            q1.Answers = a1;

            Question q2 = new Question { Name = "Najpopularniejsze zwierzę domowe" };
            List<Answer> a2 = new List<Answer>{
                new Answer{Name="Kot",Points = 30 },
                new Answer{Name="Pies",Points = 40 },
                new Answer{Name="Chomik",Points = 15}
            };
            q2.Answers = a2;
            Question q3 = new Question { Name = "Więcej niż jedno zwierzę" };
            List<Answer> a3 = new List<Answer>{
                new Answer{Name="Stado",Points = 20 },
                new Answer{Name="Lama",Points = 100}
            };
            q3.Answers = a3;

            Question q4 = new Question { Name = "Co pijemy?" };
            List<Answer> a4 = new List<Answer>{
                new Answer{Name="Wodę",Points = 20 },
                new Answer{Name="Mleko",Points = 20 },
                new Answer{Name="Wódę",Points = 100}
            };
            q4.Answers = a4;
            list.Add(q1);
            list.Add(q3);
            list.Add(q2);
            list.Add(q4);
            
            //Assert.IsTrue(QuestionsCtrl.Instance.SaveXml(list, out string msg));
        }
    }
}
