using System;
using System.Globalization;
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
        static int? fromstring(string s)
         {
          return string.IsNullOrEmpty(s) ? (int?)null : int.Parse(s);
         }

        static DateTime? fromdate(string s)
        {
            return string.IsNullOrEmpty(s) ? (DateTime?) null : Convert.ToDateTime(s, CultureInfo.InstalledUICulture);
        }

        static void Main(string[] args)
        {
            

            XmlSerializer formatter = new XmlSerializer(typeof(FILE));


            FILE peoplesbapb;
            using (FileStream fs = new FileStream("d:\\org\\SD_workman.xml", FileMode.Open))
            {

                peoplesbapb = (FILE)formatter.Deserialize(fs); ////!!

            }
            
           
          
            StreamReader structReader = new StreamReader("d:\\org\\apbstr.000.txt",Encoding.GetEncoding(1251)); //structReader указатель файла оргструктуры
            string sLine = "";
            string[] arrText;
                
            
            var podrs = new List<Podr>();
            var podrs_real = new List<Podr>(); // для действующих СП


            while (sLine != null)
            {
                sLine = structReader.ReadLine();
                if (sLine != null) {
                    //arrText.Add(sLine);
                    arrText = sLine.Split('|');
                    podrs.Add(new Podr() { ID = Int32.Parse(arrText[0]),
                        CodeSp = arrText[1] ,
                        NameBranch = arrText[2],
                        NameSp = arrText[3],
                    countrycode = fromstring(arrText[4]),
                        postindex  = fromstring(arrText[5]),
                        region = arrText[6],
                        area = arrText[7],
                        citytype = arrText[8],
                    namecity = arrText[9],
                        streettype = arrText[10],
                        streetname = arrText[11],
                        housenumber = arrText[12],
                        buildnumber = arrText[13],
                        roomnumber = fromstring(arrText[14]),
                        firstgroupnumber = fromstring(arrText[15]),
                        parentSP = arrText[16],
                        childSP = arrText[17],
                        codeBIc = fromstring(arrText[18]),
                        datebeginSP = fromdate(arrText[19]),
                        dateendSP = fromdate(arrText[20]),
                        datechangeSP = fromdate(arrText[21]),
                    });
                    /*
                    */
                }

            }
            structReader.Close();
            for (int i = podrs.Count-1; i >-1 ; i--)
            {
                if (podrs[i].dateendSP != null)
                {
                   podrs.Remove(podrs[i]);
                }
            }

            Podr root = new TreeCreator().CreateTree(podrs);
            //stringbuilder 
            Console.WriteLine(peoplesbapb.EMPLOYEES[3].FName);
            Console.WriteLine("всего сотрудников " + peoplesbapb.EMPLOYEES.Length);
            Console.WriteLine("всего подразделений " + podrs.Count);
            Console.WriteLine(podrs[ 537].CodeSp+" "+podrs[537].codeBIc+" "+podrs[537].NameBranch+" "+podrs[537].namecity+" "+podrs[537].streetname);

            Console.ReadLine();
        }
    }
}
