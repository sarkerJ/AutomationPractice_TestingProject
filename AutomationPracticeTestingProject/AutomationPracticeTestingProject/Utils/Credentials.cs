using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTestingProject
{
    public class Credentials
    {
        public Gender Gender { get; set; } = Gender.male;
        public string FirstName { get; set; } = "TestName";
        public string LastName { get; set; } = "TestSurname";
        public string Password { get; set; } = "Password123!";
        public string DOBDays { get; set; } = "5";
        public string DOBMonth { get; set; } = "March";
        public string DOBYear { get; set; } = "2017";
        public string Company { get; set; } = "CompanyName";
        public string Address { get; set; } = "Time Road";
        public string City { get; set; } = "London";
        public string State { get; set; } = "Alabama";
        public string Postcode { get; set; } = "40098";
        public string Country { get; set; } = "United States";
        public string AdditionalInformation { get; set; } = "No more information";
        public string HomePhone { get; set; } = "08472652035";
        public string MobilePhone { get; set; } = "08847265205";
    }

    public enum Gender { male, female };
}
