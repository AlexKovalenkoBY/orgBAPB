using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orgBAPB
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FILE
    {

        private FILEEMPLOYEE[] eMPLOYEESField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EMPLOYEE", IsNullable = false)]
        public FILEEMPLOYEE[] EMPLOYEES
        {
            get
            {
                return this.eMPLOYEESField;
            }
            set
            {
                this.eMPLOYEESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FILEEMPLOYEE
    {

        private string iDDivTenCharField;

        private ushort iDTabNumberField;

        private ushort tabNumberField;

        private string familyField;

        private string fNameField;

        private string patronymicField;

        private string sexField;

        private string birthDayField;

        private object adressField;

        private object officeField;

        private object phoneField;

        private object intPhoneField;

        private string emailField;

        private ushort bankCodeField;

        private uint iDDivisionField;

        private string namePostsField;

        private string beginDateField;

        private object endDateField;

        private byte activeField;

        private object beginDateVacField;

        private object endDateVacField;

        /// <remarks/>
        public string IDDivTenChar
        {
            get
            {
                return this.iDDivTenCharField;
            }
            set
            {
                this.iDDivTenCharField = value;
            }
        }

        /// <remarks/>
        public ushort IDTabNumber
        {
            get
            {
                return this.iDTabNumberField;
            }
            set
            {
                this.iDTabNumberField = value;
            }
        }

        /// <remarks/>
        public ushort TabNumber
        {
            get
            {
                return this.tabNumberField;
            }
            set
            {
                this.tabNumberField = value;
            }
        }

        /// <remarks/>
        public string Family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        public string FName
        {
            get
            {
                return this.fNameField;
            }
            set
            {
                this.fNameField = value;
            }
        }

        /// <remarks/>
        public string Patronymic
        {
            get
            {
                return this.patronymicField;
            }
            set
            {
                this.patronymicField = value;
            }
        }

        /// <remarks/>
        public string Sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }

        /// <remarks/>
        public string BirthDay
        {
            get
            {
                return this.birthDayField;
            }
            set
            {
                this.birthDayField = value;
            }
        }

        /// <remarks/>
        public object Adress
        {
            get
            {
                return this.adressField;
            }
            set
            {
                this.adressField = value;
            }
        }

        /// <remarks/>
        public object Office
        {
            get
            {
                return this.officeField;
            }
            set
            {
                this.officeField = value;
            }
        }

        /// <remarks/>
        public object Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public object IntPhone
        {
            get
            {
                return this.intPhoneField;
            }
            set
            {
                this.intPhoneField = value;
            }
        }

        /// <remarks/>
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public ushort BankCode
        {
            get
            {
                return this.bankCodeField;
            }
            set
            {
                this.bankCodeField = value;
            }
        }

        /// <remarks/>
        public uint IDDivision
        {
            get
            {
                return this.iDDivisionField;
            }
            set
            {
                this.iDDivisionField = value;
            }
        }

        /// <remarks/>
        public string NamePosts
        {
            get
            {
                return this.namePostsField;
            }
            set
            {
                this.namePostsField = value;
            }
        }

        /// <remarks/>
        public string BeginDate
        {
            get
            {
                return this.beginDateField;
            }
            set
            {
                this.beginDateField = value;
            }
        }

        /// <remarks/>
        public object EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        public byte Active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        public object BeginDateVac
        {
            get
            {
                return this.beginDateVacField;
            }
            set
            {
                this.beginDateVacField = value;
            }
        }

        /// <remarks/>
        public object EndDateVac
        {
            get
            {
                return this.endDateVacField;
            }
            set
            {
                this.endDateVacField = value;
            }
        }
    }


}
