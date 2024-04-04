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
    [DefaultClassOptions]
    public class Customer : XPObject
    { 
        public Customer(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        string address;
        string emailAddress;
        int phoneNumber;
        string lastName;
        string firstName;
        string customerID;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string CustomerID
        {
            get => customerID;
            set => SetPropertyValue(nameof(CustomerID), ref customerID, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string FirstName
        {
            get => firstName;
            set => SetPropertyValue(nameof(FirstName), ref firstName, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string LastName
        {
            get => lastName;
            set => SetPropertyValue(nameof(LastName), ref lastName, value);
        }


        public int PhoneNumber
        {
            get => phoneNumber;
            set => SetPropertyValue(nameof(PhoneNumber), ref phoneNumber, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string EmailAddress
        {
            get => emailAddress;
            set => SetPropertyValue(nameof(EmailAddress), ref emailAddress, value);
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Address
        {
            get => address;
            set => SetPropertyValue(nameof(Address), ref address, value);
        }


       
    }
}