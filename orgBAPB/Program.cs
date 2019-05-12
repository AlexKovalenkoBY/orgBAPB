using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;



namespace orgBAPB
{
    class Program
    {
        static void Main(string[] args)
        {
            

            XmlSerializer formatter = new XmlSerializer(typeof(FILEEMPLOYEESEMPLOYEE));
            

            FILEEMPLOYEESEMPLOYEE[]  peoplesbapb= new FILEEMPLOYEESEMPLOYEE();
            using (FileStream fs = new FileStream("d:\\org\\SD_workman1.xml", FileMode.Open))
            {
                peoplesbapb = (FILEEMPLOYEES)formatter.Deserialize(fs); ////!!

            }
               
        }
    }
}
