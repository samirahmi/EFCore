﻿
//class Program
//{
//    static void Main()
//    {
////==================================================================================
////INSERT TABLE STUDENT

//var student = new Student();
//student.StudentCode = "MUST";
//student.StudentName = "TRY";

//var context = new SchoolContext(); // Create object context dari SchoolContext
//context.Students.Add(student); // Menambah record baru
//context.SaveChanges(); // Simpan Perubahan

//Console.WriteLine("Sukses menambah record Baru");

//var student = new Student();
//student.StudentCode = "SIS-002";
//student.StudentName = "Hinata Shoyo";

//var context = new SchoolContext();
////context.Students.Add(student); // CARA 1

//context.Add<Student>(student); // CARA 2
//context.SaveChanges();

////==================================================================================
////UPDATE TABLE STUDENT

//var student = new Student();
//student.StudentId = 1;
//student.StudentCode = "SIS-001";
//student.StudentName = "Hyuga";

//var context = new SchoolContext();
////context.Students.Update(student); // CARA 1

//context.Update<Student>(student); //CARA 2
//context.SaveChanges();

//Console.WriteLine("Sukses memperbaharui database Students");

////==================================================================================
////DELETE TABLE STUDENT

//var context = new SchoolContext();
//var student = context.Students.FirstOrDefault(w => w.StudentId == 3); // get data student

////context.Students.Remove(student); //CARA 1

//context.Remove<Student>(student); //CARA 2
//context.SaveChanges();

//Console.WriteLine("Sukses menghapus data Student");

//DELETE Menggunakan Transaction
//var context = new SchoolContext();

//var student = context.Students.FirstOrDefault(w=>w.StudentId == 2);
//try
//{
//    context.Database.BeginTransaction(); // Transaction
//    context.Students.Remove(student);
//    context.SaveChanges();
//    context.Database.CommitTransaction();

//    Console.WriteLine("Sukses menghapus data student");
//}
//catch
//{
//    context.Database.RollbackTransactionAsync();
//}

////==================================================================================
////MELIHAT LIST TABEL STUDENT

//var context = new SchoolContext();

//var listStudent = context.Students.ToList();

//foreach (Student student in listStudent)
//{
//    Console.WriteLine($"{student.StudentId} - {student.StudentCode} - {student.StudentName}");
//}
//    }
//}

using Day15_EFCore.DataBase;
using Microsoft.EntityFrameworkCore;

//class Program
//{
//    static void Main()
//    {
        ////==================================================================================
        ////MELIHAT RECORD PERTAMA DARI TABEL STUDENT

        //var context = new SchoolContext();

        //var student = context.Students.First(); 

        //Console.WriteLine($"{student.StudentCode} - {student.StudentName}");

        ////CARA BEDA melihat 1 RECORD
        //var context = new SchoolContext();
        //var students = context
        //    .Students
        //    .FromSql($"SELECT * FROM Students WHERE StudentCode = 'SIS-001'")
        //    .FirstOrDefault(); // menggunakan perintah SQL

        //Console.WriteLine($"{students.StudentCode} - {students.StudentName}");

        //var listStudent = context.Students.Where(w => w.StudentId == 1);
        //var studentRepo = listStudent.FirstOrDefault();
        //Console.WriteLine($"{students.StudentCode} - {students.StudentName}");

        ////==================================================================================
        ////MELIHAT RECORD PERTAMA DARI TABEL STUDENT

        //var context = new SchoolContext();
        //var student = context.Students
        //    .Include(s => s.StudentAddress); // setara SELECT * FROM Student LEFT JOIN StudentAddress
        //Console.ReadKey();

        ////==================================================================================
        ////MELIHAT VIEW DARI SQL 

        //var context = new SchoolContext();
        //var viewStudentAddress = context.vw_StudentAddresses.ToList(); // mengambil semua data
        //foreach(var itemstudent in viewStudentAddress)
        //{
        //    Console.WriteLine($"{itemstudent.StudentId} - {itemstudent.StudentName}" +
        //        $" - {itemstudent.Address1} - {itemstudent.Address2}");
        //}

        ////==================================================================================
        ////PERINTAH UNTUK MENGEKSEKUSI PERINTAH NATIVE SQL, sammple adalah VIEW
        ///
        //var context = new SchoolContext();
        //context.Database.ExecuteSqlRaw(
        //    @"CREATE VIEW View_Student AS SELECT StudentId, StudentName FROM Students");

        //var context = new SchoolContext();
        //var students = context.Students.FromSqlRaw(@"SELECT * FROM dbo.""Students""");

        //foreach (var student in students)
        //{
        //    Console.WriteLine($"{student.StudentId} - {student.StudentName}");
        //}
//    }

//}

//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();
//        var student = context.Students.FirstOrDefault(w => w.StudentId == 1);

//        //student.StudentId = 1;
//        //student.StudentCode = "SIS-001";
//        //student.StudentName = "Gaara";
//        //student.DoB = System.DateTime.UtcNow;
//        //student.Gender = 1;
//        //context.Students.Update(student);
//        //context.SaveChanges();

//        Console.WriteLine($"{student.StudentId} - {student.StudentName} - {student.Gender}");
//    }
//}

class Program
{
    static void Main()
    {
        var context = new SchoolContext();
        var student1 = new Student();
        student1.StudentId = 2;
        student1.StudentCode = "SIS-002";
        student1.StudentName = "Uzumaki";
        student1.DoB = DateTime.UtcNow;
        student1.Gender = Gender.Male;

        var student2 = new Student();
        student1.StudentId = 3;
        student2.StudentCode = "SIS-003";
        student2.StudentName = "Hinata";
        student2.DoB = DateTime.UtcNow;
        student2.Gender = Gender.Female;

        var studentList = new List<Student>();
        studentList.Add(student1);
        studentList.Add(student2);

        context.Students.AddRange(studentList); //Save MultyRecord
        context.SaveChanges();

        Console.WriteLine("Multi Insert EFCore");
    }

}