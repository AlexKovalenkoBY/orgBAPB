using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orgBAPB
{
    class Podr 
    {
        public int ID; //1.	уникальный идентификационный номер записи (элемента организационно-территориальной структуры)
        public string CodeSp; //2.	код элемента организационно-территориальной структуры (10 знаков без разделения)
        public string NameBranch; //3.	наименование отдела (сектора, должности - в соответствии с Типовой организационной структурой филиала ОАО "Белагропромбанк" или Организационной структурой региональной дирекции по г. Минску ОАО "Белагропромбанк")
        public string NameSp; // 4.	управления, центра (для самостоятельных структурных подразделений Центрального аппарата - отдел, сектор), РКЦ, ЦБУ и (или) филиала, РД))
        public int? countrycode; //5.	код страны
        public long? postindex;  //  6.	почтовый индекс
        public string region; //7.	область
        public string area; //8.	район
        public string citytype; //9.	тип населенного пункта
        public string namecity; //10.	наименование населенного пункта
        public string streettype; //11.	тип улицы
        public string streetname; //12.	наименование улицы
        public string housenumber; // 13.	номер дома
        public string buildnumber; //14.	номер корпуса
        public int? roomnumber;// 15.	номер помещения
        public int? firstgroupnumber;// 16.	код группы РКЦ (1 знак)
        public string parentSP; // 17.	код родительского объекта организационно-территориальной структуры (10 знаков без разделения)
        public string childSP; //18.	код приемника (10 знаков без разделения)
        public int? codeBIc;  //19.	БИК (последние 3 цифры банковского идентификационного кода)
        public DateTime? datebeginSP; //20.	дата начала действия объекта
        public DateTime? dateendSP; //21.	дата окончания действия объекта
        public DateTime? datechangeSP; //22.	дата модификации объекта

        public List<Podr> Childs;
    }


}
