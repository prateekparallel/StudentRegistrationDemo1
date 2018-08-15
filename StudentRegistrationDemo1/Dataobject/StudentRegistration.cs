using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegistrationDemo1.Dataobject
{
    public class StudentRegistration
    {
        Dictionary<string, Student> studentList;
        static StudentRegistration stdregd = null;

        private StudentRegistration()
        {
            studentList = new Dictionary<string, Student>();
        }

        public static StudentRegistration getInstance()
        {
            if (stdregd == null)
            {
                stdregd = new StudentRegistration();
                return stdregd;
            }
            else
            {
                return stdregd;
            }
        }

        public void Add(Student student)
        {
            studentList.Add(student.RegistrationNumber, student);
        }

        public Student Remove(String registrationNumber)
        {
            Student std;
            std = studentList[registrationNumber];
            studentList.Remove(registrationNumber);
            return std;
        }

        public Dictionary<string, Student> getAllStudent()
        {
            return studentList;
        }

        public Student getStudent(String registrationNum)
        {
            return studentList[registrationNum];
        }

        public String UpdateStudent(Student std)
        {
            String reply = "Student List Updated successfully";
            studentList[std.RegistrationNumber] = std;
            return reply;
        }


    }
    }