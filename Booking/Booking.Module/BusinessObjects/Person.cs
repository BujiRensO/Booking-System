using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Booking.Module.BusinessObjects
{
    public class Person : XPObject
    { 
        public Person(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        Address address;
        string email;
        int phoneNumber;
        int age;
        string lastName;
        string middleName;
        string firstName;
        string fullName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string City
        {
            get => fullName;

        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string FirstName
        {
            get => firstName;
            set => SetPropertyValue(nameof(FirstName), ref firstName, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string MiddleName
        {
            get => middleName;
            set => SetPropertyValue(nameof(MiddleName), ref middleName, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string LastName
        {
            get => lastName;
            set => SetPropertyValue(nameof(LastName), ref lastName, value);
        }


        public int Age
        {
            get => age;
            set => SetPropertyValue(nameof(Age), ref age, value);
        }


        public int PhoneNumber
        {
            get => phoneNumber;
            set => SetPropertyValue(nameof(PhoneNumber), ref phoneNumber, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Email

        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }

        
        public Address Address
        {
            get => address;
            set => SetPropertyValue(nameof(Address), ref address, value);
        }

    }
}