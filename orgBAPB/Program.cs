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
            
           
          
            StreamReader structReader = new StreamReader("d:\\org\\apbstr.000.txt"); //structReader ��������� ����� ������������
            string sLine = "";
            ArrayList arrText = new ArrayList();
            int count = 0;
            while (sLine != null)
            {
                sLine = structReader.ReadLine();
                if (sLine != null) { 
                    arrText.Add(sLine);
                    count++;
                }

            }
            structReader.Close();
            Console.WriteLine(peoplesbapb.EMPLOYEES[3]);
            Console.WriteLine("����� ����������� " + peoplesbapb.EMPLOYEES.Length);
            Console.WriteLine("����� ������������� " + count);
            Console.WriteLine(arrText[13]);
            Console.ReadLine();
        }
    }
}
