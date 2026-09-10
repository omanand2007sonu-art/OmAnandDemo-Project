using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OmAnandDemo
{
    internal class VoterIdRegistration
    {
        public string? _voterName;
        public string _voterFatherName = string.Empty;
        public string _voterMotherName = string.Empty;
        public DateTime _voterDateOfBirth = DateTime.MinValue;
        public string _voterVillageName = string.Empty;
        public string _voterBlockName = string.Empty;
        public int _wardNumber = 0;
        public string _voterDistrictName = string.Empty;
        public long _voterAadharNumber = 0;
        public long _voterPhoneNumber = 0;

        public string _voterPinCode = string.Empty;

        public VoterIdRegistration()
        {

        }

        public VoterIdRegistration(string voterName, string voterFatherName, string voterMotherName, DateTime voterDateOfBirth, string voterVillageName, string voterBlockName, int wardNumber, string voterDistrictName, long voterAadharNumber, long voterPhoneNumber, string voterPinCode)
        {
            _voterName = voterName;
            _voterFatherName = voterFatherName;
            _voterMotherName = voterMotherName;
            _voterDateOfBirth = voterDateOfBirth;
            _voterVillageName = voterVillageName;
            _voterBlockName = voterBlockName;
            _wardNumber = wardNumber;
            _voterDistrictName = voterDistrictName;
            _voterAadharNumber = voterAadharNumber;
            _voterPhoneNumber = voterPhoneNumber;
            _voterPinCode = voterPinCode;
        }

        public void displayVoterDetails()
        {
            Console.WriteLine($"Enter Your Phone Number");
            _voterPhoneNumber = Convert.ToInt64(Console.ReadLine());

            if (_voterPhoneNumber == 8123414418)
            {
                _voterName = "Sampat";
                _voterFatherName = "M P Yadav";
                _voterMotherName = "Hiran Devi";
                _voterDateOfBirth = new DateTime(1991, 12, 31);
                _voterVillageName = "Kainjari";
                _voterBlockName = "Beldaur";
                _wardNumber = 8;
                _voterDistrictName = "Khagaria";
                _voterAadharNumber = 123456789012;
                _voterPhoneNumber = 1234567890;

                Console.WriteLine($"Voter Name: {_voterName} Father Name {_voterFatherName} Mother Name {_voterMotherName} Date of Birth: {_voterDateOfBirth} Village: {_voterVillageName} Block: {_voterBlockName} Ward: {_wardNumber} District: {_voterDistrictName} Aadhar Number: {_voterAadharNumber} Phone Number: {_voterPhoneNumber}");
            }

            else if (_voterPhoneNumber == 9155543265)
            {
                _voterName = "OM Anand";
                _voterFatherName = "Deepak Kumar";
                _voterMotherName = "Lalita Devi";
                _voterDateOfBirth = new DateTime(2007, 06, 06);
                _voterVillageName = "Kainjari";
                _voterBlockName = "Beldaur";
                _wardNumber = 8;
                _voterDistrictName = "Khagaria";
                _voterAadharNumber = 39865756833;
                _voterPhoneNumber = 1234567889;
                Console.WriteLine($"Voter Name: {_voterName} Father Name {_voterFatherName} Mother Name {_voterMotherName} Date of Birth: {_voterDateOfBirth} Village: {_voterVillageName} Block: {_voterBlockName} Ward: {_wardNumber} District: {_voterDistrictName} Aadhar Number: {_voterAadharNumber} Phone Number: {_voterPhoneNumber}");
            }
            else
            {
                Console.WriteLine("You are not eligible for Voter ID Registration");
            }

            

        }

        public void displayConsolidatedVoterName()
        {

            VoterIdRegistration object1 = new VoterIdRegistration();
            object1._voterName = "Sampat";
            object1._voterFatherName = "M P Yadav";
            object1._voterMotherName = "Hiran Devi";
            object1._voterDateOfBirth = new DateTime(1991, 12, 31);
            Console.WriteLine($"Details from the second Object: Voter Name: {object1._voterName} Father Name: {object1._voterFatherName} Mother Name: {object1._voterMotherName} Date of Birth: {object1._voterDateOfBirth}");


            VoterIdRegistration object2 = new VoterIdRegistration();
            object2._voterName = "Om Anand";
            object2._voterFatherName = "Deepak Kumar";
            object2._voterMotherName = "Lalita Devi";
            object2._voterDateOfBirth = new DateTime(2007, 06, 06);
            Console.WriteLine($"Details from the third Object: Voter Name: {object2._voterName} Father Name: {object2._voterFatherName} Mother Name: {object2._voterMotherName} Date of Birth: {object2._voterDateOfBirth}");

        }

        static void Main(string[] args)
        {
            VoterIdRegistration voter3 = new VoterIdRegistration();
            voter3.displayConsolidatedVoterName();
            voter3.displayVoterDetails();
            

   
           

            Console.ReadKey();


        }
    }
}
