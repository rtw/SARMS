﻿namespace Sarms.Domain
{
    public class Student : Account
    {
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public Course Course { get; set; }
        public int EnrolmentStatus { get; private set; }

        public void ChangeEnrollStatus(int status)
        {
            EnrolmentStatus = status;
        }
    }
}