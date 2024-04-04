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
    public class Address : XPObject
    {
        public Address(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        string postalCode;
        string region;
        string province;
        string city;
        string district;
        string addressLine;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AddressLine
        {
            get => addressLine;
            set => SetPropertyValue(nameof(AddressLine), ref addressLine, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string District
        {
            get => district;
            set => SetPropertyValue(nameof(District), ref district, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string City
        {
            get => city;
            set => SetPropertyValue(nameof(City), ref city, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Province
        {
            get => province;
            set => SetPropertyValue(nameof(Province), ref province, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Region
        {
            get => region;
            set => SetPropertyValue(nameof(Region), ref region, value);
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string PostalCode
        {
            get => postalCode;
            set => SetPropertyValue(nameof(PostalCode), ref postalCode, value);
        }
    }
}