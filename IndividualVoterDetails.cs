using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Reflection.PortableExecutable;
using System.Text;

namespace OmAnandDemo
{
    public class IndividualVoterDetails : VoterIdRegistration
    {
       public string? voterIdRegistrationNumber = string.Empty;

        
        public void generateVoterIdRegistrationNumber()
        {

            /*These below fields and are directly inherited from the Parent Class 'VoterIdRegistration'.
             
             These fields and Methods can be used only inside a Method of the Child Class. They cannot be used outside the Method of the Child Class as Local variables or Local Methods.
             
             
             
             
             */


            _voterFatherName = "Anand Kumar";
            _voterMotherName = "Sita Devi";
            _voterName = "OmAnand";
            _voterDateOfBirth = new DateTime(1990, 1, 1);
            VIDNumber = "123456789012";

            voterIdRegistrationNumber = _voterName.Substring(0, 4) + Convert.ToInt32(VIDNumber.Substring(0, 3));

            Console.WriteLine("Voter ID Registration Number: " + voterIdRegistrationNumber);

            
        }

        
        public void displayVoterDetail()
        {
            displayVoterDetails();
        }

         static void Main(string[] args)
        {
            IndividualVoterDetails individualVoter = new IndividualVoterDetails();
            individualVoter.generateVoterIdRegistrationNumber();

            individualVoter.displayVoterDetail();



        }
    }


    /*Multi Level Inheritance
     
     IndividualVoterDetails : VoterIdRegistration


     VoterIdRegistrationDemo : IndividualVoterDetails
     
     */
    public class VoterIdRegistrationDemo : IndividualVoterDetails
    {
        public void displayVoterInformation()
        {
            generateVoterIdRegistrationNumber();
            displayVoterDetails();
        }
        static void Main(string[] args)
        {
            VoterIdRegistrationDemo voterIdRegistrationDemo = new VoterIdRegistrationDemo();
            voterIdRegistrationDemo.displayVoterInformation();
        }
    }
}
