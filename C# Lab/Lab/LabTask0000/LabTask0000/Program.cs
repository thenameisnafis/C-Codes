using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask0000
{
        public class Bank
        {
            public int AccountNumber { get; set; }
            public string AccountHolderName { get; set; }
            public string ID { get; set; }
            public string DOB { get; set; }
            public string Gender { get; set; }

            public Bank(int accountNumber, string accountHolderName, string id, string dob, string gender)
            {
                AccountNumber = accountNumber;
                AccountHolderName = accountHolderName;
                ID = id;
                DOB = dob;
                Gender = gender;
            }

            public void Display()
            {
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Account Holder Name: " + AccountHolderName);
                Console.WriteLine("ID: " + ID);
                Console.WriteLine("Date of Birth: " + DOB);
                Console.WriteLine("Gender: " + Gender);
            }
        }
}

