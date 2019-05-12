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
            

            XmlSerializer formatter = new XmlSerializer(typeof(FILE2));


            FILE2 peoplesbapb;
            using (FileStream fs = new FileStream("d:\\org\\SD_workman1.xml", FileMode.Open))
            {
                peoplesbapb = (FILE2)formatter.Deserialize(fs); ////!!

            }
           // for int i=1 lenght.
           // peoplesbapb.EMPLOYEES.
            
        }
    }
}
