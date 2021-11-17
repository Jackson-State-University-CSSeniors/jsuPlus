﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsuPlus.Core.SharedKernel;
using JsuPlus.Core.Entities;

namespace JsuPlus.Core.Entities
{
    public class Address : ValueObject
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string Zipcode { get; private set; }

        public Address() { }

        public Address(string street, string city, string state, string country, string zipcode)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            Zipcode = zipcode;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            //Using a yield return statement to return each element one at a time
            yield return Street;
            yield return City;
            yield return State;
            yield return Country;
            yield return Zipcode;
        }
    }
}
