using System;

namespace SingleResponsibilityPrinciple
{
    public class Account
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public int ZipCode { get; set; } 

        public string City { get; set; }

        public Guid AccountId { get; set; } 

        public string UserName { get; set; }
        
        public string Password { get; set; }

        public void ChangePassword(Guid AccountId, string newPassword) => Console.WriteLine($"The Account of {AccountId} Password changed to new password {newPassport}");

        public void ChangeAdress(string Street, int ZipCode, string City) => Console.WriteLine($"Address Changed");
    }

}
