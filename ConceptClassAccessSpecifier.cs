using System;
using System.Collections.Generic;
using System.Text;

/*  what are 'using' statements?
 
    These "using" Statements are "Importing Namespaces"/ "Inbuilt libraries" given by Microsoft.
    In the Library of Our Language i.e. "Base Class Libraries",there are so many pre-defined Classes and 
    All those classes are defined under Some namespaces.
    Hence, To Consume those classes in our Code,we need to import those Namespaces.
    e.g. 'System' Namespace has hundreds of Classes defined under it and it is important for us to use these Namespaces.
    System and various other packages here actually provide us the ability to import classes predefined under them.



    what is a namespace?
    namespace is a 'logical' Container of 'Types'.
    It is called Logical Container because it does not have a Physical Existence.
    Generally we use it for Grouping the Items. 
    e.g. Folders in our Operating Systems are Containers for Storing Files.
    Files have Physical Existence but are grouped inside Folders.
    Similarly Our .NET Programming Languages are provided with Logical Containers called 'Namespace'.
    Suppose we have Ten Classes in our Project, we can group it into Two Containers.

    So we can group five-five classes under Two Namespaces.
    By default the name of Namespace is Project name itself but we can change that also.



 
 */


namespace OmAnandDemo
{
    /*This is my First Project - C# Console Application
     
    The Default Access Specifier for a class is internal. It means that the class is accessible only within the same assembly. 
    If you want to make a class accessible from other assemblies, you need to use the public access specifier.
     
     
     */
    internal class ConceptClassAccessSpecifier
    {
  

        /*  1. Field = Data = Variable 
            2. Property = Getters and Setters = Used to Impelment 'Encapsulation'
            3. Constructor = It will initialize the variables with their default value
            4. Method = Function

        */

        /* Access Specifiers: 
           1. Private: Accessible only within the class.
           2. Protected: Accessible within the class and its derived classes.
           3. Internal: Accessible within the same assembly.
           4. Protected Internal: Accessible within the same assembly and derived classes.
           5. Public: Accessible from anywhere.

       */


        private int departmentId;
                

        /*Concept of encapsulation using Property */
        public int DeptId
        {
            get { return departmentId; } 
            set { departmentId = value; } 
        
        }

        /*Protected Field*/
        protected string departmentCode = string.Empty;

        /*Internal Field*/
        internal DateTime departmentEstablishedDate;

        /*Protected Internal Field*/
        protected internal decimal departmentSalary;

        /*Public Field*/
        public string departmentName = string.Empty;



        /* 3. Constructor = It will initialize the variables with their default value */

            /*Default or Parameterless */
                public ConceptClassAccessSpecifier()
                {
                    this.departmentId = 1;
                    this.departmentCode = "CS01";
                    this.departmentName = "Computer Science";
                    this.departmentEstablishedDate = new DateTime(2018, 10, 10);

                    Console.WriteLine($"Department ID: {departmentId}, Department Code: {departmentCode}, Department Name: {departmentName}, Department Established Date: {departmentEstablishedDate}");
                }


            /*Parameterized Constructor */
                public ConceptClassAccessSpecifier(int deptId, string deptCode,string deptName, DateTime deptEstablishedDate, decimal deptSalary)
                {
                    this.departmentId = deptId;
                    this.departmentCode = deptCode;
                    this.departmentName = deptName;
                    this.departmentEstablishedDate = deptEstablishedDate;

                    Console.WriteLine($"Department ID: {departmentId}, Department Code: {departmentCode}, Department Name: {departmentName}, Department Established Date: {departmentEstablishedDate}");
                }

    /* Constructor ends - Default or Parameterless */


    /* 3. Method starts */


                private void displayDepartmentDetails()
                {
                    departmentId = 3;
                    departmentCode = "MechDept";
                    departmentName = "Computer Science";
                    departmentEstablishedDate = new DateTime(2020, 10, 10);
                  
                    Console.WriteLine($"Department ID: {departmentId}, Department Code: {departmentCode}, Department Name: {departmentName}, Department Established Date: {departmentEstablishedDate}");

                }

                protected void displayDepartmentCode()
                {
                    Console.WriteLine("Department Code: " + departmentCode);
                }

                internal void displayDepartmentEstablishedDate()
                {
                    Console.WriteLine("Department Established Date: " + departmentEstablishedDate);
                }

                protected internal void displayDepartmentSalary(int empGrade)
                {
                    if (empGrade == 1)
                    {
                        Console.WriteLine("Department Salary: $50,000");
                    }
                    else if (empGrade == 2)
                    {
                        Console.WriteLine("Department Salary: $60,000");
                    }
                    else
                    {
                        Console.WriteLine("Invalid employee grade.");
                    }
                }






        /* Main Method starts 
     
           It is the Entry point of the Project.
     
           when an Object of this Class will be created, the Compiler will look for the Main Method and will execute the code written inside it. 
     
        */

        static void Main(string[] args)
        {
            /*This is the default constructor call
             Default Constructor is called when no parameters are passed to the constructor. It initializes the object with default values. */
            ConceptClassAccessSpecifier dept = new ConceptClassAccessSpecifier();

            /*This is the parameterized constructor call
            Parameterized Constructor is called when parameters are passed to the constructor. It initializes the object with the provided values.*/
            ConceptClassAccessSpecifier deptDemo = new ConceptClassAccessSpecifier(2, "IT01", "Information Technology", new DateTime(2022, 10, 10),0);



            dept.displayDepartmentDetails();

            

        }


    }

}
