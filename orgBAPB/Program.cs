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

            while (sLine != null)
            {
                sLine = structReader.ReadLine();
                if (sLine != null) {
                    //arrText.Add(sLine);
                    arrText = sLine.Split('|');
                    podrs.Add(new Podr() { ID = Int32.Parse(arrText[0]), CodeSp = arrText[1] , NameBranch = arrText[2], NameSp = arrText[3],
                    countrycode = Int32.Parse(arrText[4]), postindex  = Int32.Parse(arrText[5]), region = arrText[6], area = arrText[7], citytype = arrText[8]});/*
                    namecity = arrText[9], streettype = arrText[10], streetname = arrText[11], housenumber = Int32.Parse(arrText[12]), buildnumber = Int32.Parse(arrText[13]),
                        roomnumber = Int32.Parse(arrText[14]), firstgroupnumber = Int32.Parse(arrText[15]), paretnSP = arrText[16],  childSP = arrText[17], codeBIc = Int32.Parse(arrText[18]),
                        datebeginSP = Convert.ToDateTime(arrText[19], CultureInfo.InstalledUICulture), datechangeSP = Convert.ToDateTime(arrText[20], CultureInfo.InstalledUICulture),
                        dateendSP = Convert.ToDateTime(arrText[21],CultureInfo.InstalledUICulture) 
                    */
                }

            }
            structReader.Close();
            Console.WriteLine(peoplesbapb.EMPLOYEES[3].FName);
            Console.WriteLine("всего сотрудников " + peoplesbapb.EMPLOYEES.Length);
            Console.WriteLine("всего подразделений " + podrs.Count);
            Console.WriteLine(podrs[ 537].CodeSp+" "+podrs[537].codeBIc+" "+podrs[537].NameBranch+" "+podrs[537].namecity+" "+podrs[537].streetname);

            Console.ReadLine();
        }
    }
}
