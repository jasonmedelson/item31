//Program By Jason Edelson
//Written in C#
//C# and ASP.NET Course Item 31
//Data in excel sheet was imported into SQL Server
//SQL Server was connected to Visual Studio's and added to project solution using ADO.net Entity Data Model

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace item31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NCAA Tournament 2017");
            using (var mycon = new excel_dataEntities()) // Connect to Database
            {
                for (var i = 1; i < 16; i++)//16 seeds in the tournament
                {
                    var rank = "Teams that are Seed #" + i; //string with current seed
                    Console.WriteLine(rank);
                    foreach (var team in mycon.excels.ToList())
                    { 
                        if (team.Seed == i)//search for teams with correct seed
                        {                            
                           Console.Write(team.Name + " ");
                        }
                    }
                    Console.WriteLine("");
                }
            }
            Console.Read();
        }
    }
}
