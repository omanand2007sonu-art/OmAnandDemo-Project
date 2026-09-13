using System;
using System.Collections.Generic;
using System.Text;

namespace OmAnandDemo
{ 
    /*This is my First Project - C# Console Application*/
    public class ConceptClassAccessSpecifier
    {
   



    }

    public class DepartmentDemo001
    {

        /*  1. Field = Data = Variable 
            2. Property = Getters and Setters
            3. Constructor = It will initialize the variables with their default value
            4. Method = Function

        */

        /* Access Specifiers: 
           1. Private: Accessible only within the class.
           2. Protected: Accessible within the class and its derived classes.
           3.  Internal: Accessible within the same assembly.
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


    /* Field Ends */


    /* 2. Constructor = It will initialize the variables with their default value */

            /*Default or Parameterless */
                public DepartmentDemo001()
                {
                    this.departmentId = 1;
                    this.departmentCode = "CS01";
                    this.departmentName = "Computer Science";
                    this.departmentEstablishedDate = new DateTime(2018, 10, 10);

                    Console.WriteLine($"Department ID: {departmentId}, Department Code: {departmentCode}, Department Name: {departmentName}, Department Established Date: {departmentEstablishedDate}");
                }


            /*Parameterized Constructor */
                public DepartmentDemo001(int deptId, string deptCode,string deptName, DateTime deptEstablishedDate)
                {
                    departmentId = deptId;
                    departmentCode = deptCode;
                    departmentName = deptName;
                    departmentEstablishedDate = deptEstablishedDate;

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
                  
                    Console.WriteLine("Department ID: " + departmentId);
                    Console.WriteLine("Department Code: " + departmentCode);
                    Console.WriteLine("Department Name: " + departmentName);
                    Console.WriteLine("Department Established Date: " + departmentEstablishedDate);
                    
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



        /* Method Ends */


    /* 4. Main Method starts */

        static void Main(string[] args)
        {
            /*This is the default constructor call
             Default Constructor is called when no parameters are passed to the constructor. It initializes the object with default values. */
            DepartmentDemo001 dept = new DepartmentDemo001();

            /*This is the parameterized constructor call
            Parameterized Constructor is called when parameters are passed to the constructor. It initializes the object with the provided values.*/
            DepartmentDemo001 deptDemo = new DepartmentDemo001(2, "IT01", "Information Technology", new DateTime(2022, 10, 10));



            dept.displayDepartmentDetails();

            

        }


    }


    /* Main Method ends */


   
    public class EmployeeDemo001 : DepartmentDemo001
    {
        private int employeeId;
        public string employeeName = string.Empty;
        protected string employeeDepartment = string.Empty;

        protected internal long employeePhoneNumber;

        internal decimal employeeSalary;
        private void displayEmployeeId()
        {
            Console.WriteLine("Employee ID: " + employeeId);
        }
        public void displayEmployeeDepartmentDetails(string deptName)
        {
            Console.WriteLine($"Employee Department Code : {departmentCode}, Employee Department Name: {deptName}");

        }
        public void displayEmployeeSalary(int empGrade)
        {

        }

        static void Main(string[] args)
        {
            DepartmentDemo001 dept = new DepartmentDemo001();

            EmployeeDemo001 emp = new EmployeeDemo001();
            emp.employeeId = 1;
            emp.employeeName = "Om Anand";

            emp.employeeDepartment = "IT";
            emp.employeePhoneNumber = 1234567890;

            
            Console.WriteLine("Employee ID: " + emp.employeeId + "Department Id" + dept.DeptId);


            emp.displayEmployeeDepartmentDetails("IT");

        }
    }
}
