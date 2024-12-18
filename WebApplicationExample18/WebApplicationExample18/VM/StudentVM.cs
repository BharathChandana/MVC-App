using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationExample18.Models;

namespace WebApplicationExample18.VM
{
    public class StudentVM
    {
        public Student student;
        public int Total;
        public string Result;
        public string Grade;
        public int Average;
        public string Colorname;
        public string Color;
        public StudentVM(Student s)
        {
            student = s;
            Total = student.s1+student.s2+student.s3+student.s4+student.s5+student.s6;
            Result = "Fail";
            if(student.s1>=35&&student.s2>=35&&student.s3>=35&&student.s4>=35&&student.s5>=35&&student.s6>=35)
            {
                Result = "Pass";
            }
            int p = Total / 6;
            if(Result=="Pass")
            {
                if(p>=90)
                {
                    Grade = "A+";
                    Color = "Yellow";
                } 
                else if(p>=80)
                {
                    Grade = "A";
                    Color = "Gray";
                }
                else if (p>=70)
                {
                    Grade = "B";
                    Color = "Blue";
                }
                else if (p>=60)
                {
                    Grade = "C";
                    Color = "orange";
                }
                else if (p>=50)
                {
                    Grade = "D";
                    Color = "Pink";
                }
                else if (p>=35)
                {
                    Grade = "E";
                    Color = "Lightblue";
                }
                
            }
            Average = Total / 6;
            Colorname = Result == "Pass" ? "green" : "red";
            
        }
    }
}