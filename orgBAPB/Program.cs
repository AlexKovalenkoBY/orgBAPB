using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Collections;


namespace orgBAPB
{
    class Program
    {
        static void Main(string[] args)
        {
            

            XmlSerializer formatter = new XmlSerializer(typeof(FILE));


            FILE peoplesbapb;
            using (FileStream fs = new FileStream("d:\\org\\SD_workman1.xml", FileMode.Open))
            {

                peoplesbapb = (FILE)formatter.Deserialize(fs); ////!!

            }
            
           
          
            StreamReader structReader = new StreamReader("d:\\org\\apbstr.000.txt",Encoding.GetEncoding(1251)); //structReader указатель файла оргструктуры
            string sLine = "";
            string[] arrText;
                
            
            var podrs = new List<Podr>();

            while (sLine != null)
            {
                sLine = structReader.ReadLine();
                if (sLine != null) {
                    //arrText.Add(sLine);
                    arrText = sLine.Split('|');
                    podrs.Add(new Podr() { ID = int.Parse(arrText[0]), CodeSp = arrText[1] });
                    
                }

            }
            structReader.Close();
            Console.WriteLine(peoplesbapb.EMPLOYEES[3].FName);
            Console.WriteLine("всего сотрудников " + peoplesbapb.EMPLOYEES.Length);
            Console.WriteLine("всего подразделений " + podrs.Count);
            Console.WriteLine(podrs[537].CodeSp+" "+podrs[537].codeBIc+" "+podrs[537].NameBranch+" "+podrs[537].namecity+" "+podrs[537].streetname);

            Console.ReadLine();
        }
    }
}
