using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests 
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        //private string firstname;
        //private string middlename;
        //private string lastname;
        //private string nickname;
        //private string title;
        //private string company;
        //private string address;
        //private string home;
        //private string mobile;
        //private string work;
        //private string fax;
        //private string email;
        //private string email2;
        //private string email3;
        //private string homepage;
        //private string bday;
        //private string bmonth;
        //private string byear;
        //private string aday;
        //private string amonth;
        //private string ayear;
        //private string new_group;
        //private string address2;
        //private string phone2;
        //private string notes;

        //public ContactData(string firstname, string lastname)
        //{
        //    this.firstname = firstname;
        //    this.lastname = lastname;
        //}

        public ContactData(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        public ContactData()
        {
            return;
        }
        public ContactData(string firstname)
        {
            Firstname = firstname;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            if (this.Firstname != other.Firstname)
            {
                return Firstname.CompareTo(other.Firstname);
            }
            if (this.Lastname != other.Lastname)
            {
                return Lastname.CompareTo(other.Lastname);
            }
            return 0;
        }

        public override int GetHashCode()
        {
            return Lastname.GetHashCode() & Firstname.GetHashCode();
        }
        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Firstname == other.Firstname && Lastname == other.Lastname;
        }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Nickname { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Home { get; set; }
        public string Mobile { get; set; }
        public string Work { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Homepage { get; set; }
        public string Bday { get; set; }
        public string Bmonth { get; set; }
        public string Byear { get; set; }
        public string Aday { get; set; }
        public string Amonth { get; set; }
        public string Ayear { get; set; }
        public string New_group { get; set; }
        public string Address2 { get; set; }
        public string Phone2 { get; set; }
        public string Notes { get; set; }
        public string Id { get; set; }

    }
}
