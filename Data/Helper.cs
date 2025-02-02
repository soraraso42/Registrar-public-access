﻿namespace Registrar;

public class Helper
{
  public static List<Course> GetCourses ()
  {
    List<Course> courses = [];

    Course course = new Course
    {
      Code = "CST8282",
      Title = "Introduction to Database Systems",
      WeeklyHours = 4
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8253",
      Title = "Web Programming II",
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8256",
      Title = "Web Programming Language I",  
      WeeklyHours = 5
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8255",
      Title = "Web Imaging and Animations",  
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8254",
      Title = "Network Operating System",  
      WeeklyHours = 1
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2200",
      Title = "Data Warehouse Design",  
      WeeklyHours = 3
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2240",
      Title = "Advance Database topics",  
      WeeklyHours = 1
    };
    courses.Add(course);   

    return courses;
  }

  private static readonly Random random = new Random();

  public static List<Student> studentsList = GetStudents();
  // keep a static database of students  
  //instead of calling it every time Home reload
  public static List<Student> GetStudents()
  {
    List<Student> students = [];
    Student student = new Student{
      Id = GetStudentNumber(),
      // Id = 222222,
      FirstName = "1FN",
      LastName = "1LN",
      Type = GetStudentTypes()[random.Next(3)],
      courses = GetCourses(),
    };
    students.Add(student);
    
      student = new Student{
      Id = GetStudentNumber(),
      FirstName = "2FN",
      LastName = "2LN",
      Type = GetStudentTypes()[random.Next(3)],
      courses = GetCourses(),
    };
    students.Add(student);

    student = new Student{
      Id = GetStudentNumber(),
      FirstName = "3FN",
      LastName = "3LN",
      Type = GetStudentTypes()[random.Next(3)],
      courses = GetCourses(),
    };
    students.Add(student);

    student = new Student{
      Id = GetStudentNumber(),
      FirstName = "4FN",
      LastName = "4LN",
      Type = GetStudentTypes()[random.Next(3)],
      courses = GetCourses(),
    };
    students.Add(student);

    student = new Student{
      Id = GetStudentNumber(),
      FirstName = "5FN",
      LastName = "5LN",
      Type = GetStudentTypes()[random.Next(3)],
      courses = GetCourses(),
    };

    students.Add(student);

    return students;

  }
  public static List<string> GetStudentTypes () {
    return ["Full Time", "Part Time", "Coop"];
  }

  // using Random class to statically generate student number
  // NOTE: instantiate random OUTSIDE loop to avoid unexpected behaviour (5 digits)
  private static int GetStudentNumber(){
    string s = "";
    for (int i = 0; i < 6; i++)
       { s +=  random.Next(10).ToString();};
    int number = 0;
    int.TryParse(s, out number);
    return number;
}
}
