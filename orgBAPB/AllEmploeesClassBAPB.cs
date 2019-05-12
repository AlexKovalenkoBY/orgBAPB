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
        public class FILE
        {

            public FILEEMPLOYEES eMPLOYEESField;

            /// <remarks/>
            public FILEEMPLOYEES EMPLOYEES
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
        public class FILEEMPLOYEES
        {

            /// <remarks/> определи заись об 1 чел.
            public FILEEMPLOYEESEMPLOYEE[] EMPLOYEE { get; set; }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public class FILEEMPLOYEESEMPLOYEE //свойств одной записи

        {

            private string iDDivTenCharField;

            private ushort iDTabNumberField;

            private ushort tabNumberField;

            private string familyField;

            private string fNameField;

            private string patronymicField;

            private string sexField;

            private string birthDayField;

            private string adressField;

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

            public FILEEMPLOYEESEMPLOYEE()
            {
            }

            public FILEEMPLOYEESEMPLOYEE(string iDDivTenCharField, ushort iDTabNumberField, ushort tabNumberField, string familyField, string fNameField, string patronymicField, string sexField, string birthDayField, string adressField, object officeField, object phoneField, object intPhoneField, string emailField, ushort bankCodeField, uint iDDivisionField, string namePostsField, string beginDateField, object endDateField, byte activeField, object beginDateVacField, object endDateVacField, string iDDivTenChar, ushort iDTabNumber, ushort tabNumber, string family, string fName, string patronymic, string sex, string birthDay, string adress, object office, object phone, object intPhone, string email, ushort bankCode, uint iDDivision, string namePosts, string beginDate, object endDate, byte active, object beginDateVac, object endDateVac)
            {
                this.iDDivTenCharField = iDDivTenCharField;
                this.iDTabNumberField = iDTabNumberField;
                this.tabNumberField = tabNumberField;
                this.familyField = familyField;
                this.fNameField = fNameField;
                this.patronymicField = patronymicField;
                this.sexField = sexField;
                this.birthDayField = birthDayField;
                this.adressField = adressField;
                this.officeField = officeField;
                this.phoneField = phoneField;
                this.intPhoneField = intPhoneField;
                this.emailField = emailField;
                this.bankCodeField = bankCodeField;
                this.iDDivisionField = iDDivisionField;
                this.namePostsField = namePostsField;
                this.beginDateField = beginDateField;
                this.endDateField = endDateField;
                this.activeField = activeField;
                this.beginDateVacField = beginDateVacField;
                this.endDateVacField = endDateVacField;
                IDDivTenChar = iDDivTenChar;
                IDTabNumber = iDTabNumber;
                TabNumber = tabNumber;
                Family = family;
                FName = fName;
                Patronymic = patronymic;
                Sex = sex;
                BirthDay = birthDay;
                Adress = adress;
                Office = office;
                Phone = phone;
                IntPhone = intPhone;
                Email = email;
                BankCode = bankCode;
                IDDivision = iDDivision;
                NamePosts = namePosts;
                BeginDate = beginDate;
                EndDate = endDate;
                Active = active;
                BeginDateVac = beginDateVac;
                EndDateVac = endDateVac;
            }

            /// <remarks/> 10 зн ИД подразделения
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

            /// <remarks/> табельный номер
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

            /// <remarks/> пол
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

            /// <remarks/> дата рождения
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

            /// <remarks/> адрес 
            public string Adress
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

            /// <remarks/> место работы
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

            /// <remarks/> телефон
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

            /// <remarks/> внутр телефон
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

            /// <remarks/> адрес ЭПОН
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

            /// <remarks/> код подразделения
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

            /// <remarks/> ИД подразделения
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

            /// <remarks/> Должность
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

            /// <remarks/> дата начала работы
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

            /// <remarks/> дата увольнения
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

            /// <remarks/> признак активности
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

            /// <remarks/> дата открытия вакансии (м.б. пустой)
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

            /// <remarks/> дата закрытия вакансии (м.б. пустой)
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
