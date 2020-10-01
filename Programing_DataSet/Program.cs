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

        }
    }
}
