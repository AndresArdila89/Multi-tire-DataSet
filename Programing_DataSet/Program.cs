using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // DataSet: The class defined in the AOD.Net Object Model
            // Dataset Object created from the Class DataSet: a collection of DataTables
            // DataSet Object: In-memory representation of data downloaded from a datasouce
            //                  (e.g a table from a database)
            // DataSet Structure: A collection (set)  of DataTables objects a DataTable is a collection of rows and colums

            //Q2 Declare and create an object of type  DataSet and name the object as CollegeDS.
            //Display the name of the DataSet onject on the Screeen 

            DataSet dsCollege = new DataSet("CollegeDS");

            Console.WriteLine("\n\n\nThe name of the DataSet object: " + dsCollege.DataSetName);

            //Q3: Declare and 

            DataTable dtStudents = new DataTable("Students");
            DataTable dtCourses = new DataTable("Courses");
            DataTable dtStudentCourses = new DataTable("StudentCourses");
            Console.WriteLine("\n\n\nThe name of the DataTable object (Students): " + dtStudents.TableName);

            //Q4: 

            dsCollege.Tables.Add(dtCourses);
            dsCollege.Tables.Add(dtStudents);
            dsCollege.Tables.Add(dtStudentCourses);

            //Q5
            Console.WriteLine("number of dataTables :" , dsCollege.Tables.Count);
            Console.WriteLine("number of dataTables :", dtCourses.TableName);
            Console.WriteLine("number of dataTables :", dtStudents.TableName);
            Console.WriteLine("number of dataTables :", dtStudentCourses.TableName);


            foreach (DataTable item in dsCollege.Tables)
            {
                Console.WriteLine(item.TableName);
            }

            //Q6:

            dtStudents.Columns.Add("StudentId", typeof(Int32));
            dtStudents.Columns.Add("FirstName", System.Type.GetType("System.String"));
            dtStudents.Columns.Add("LastName", System.Type.GetType("System.String"));
            dtStudents.PrimaryKey = new DataColumn[] { dtStudents.Columns["StudentId"]};


        }
    }
}
