using System;
using System.Linq;
namespace Transcription
{
    class Program
    {


        static TransccriptionProgram[] programList = {
new TransccriptionProgram {
ProgramId = "p1",
EmployeeId = "e1",
Type = "Literary Text"
},
new TransccriptionProgram {
ProgramId = "p2",
EmployeeId = "e2",
Type = "Mathematical Text"
},
new TransccriptionProgram {
ProgramId = "p3",
EmployeeId = "e3",
Type = "Musical Scores"
},
new TransccriptionProgram {
ProgramId = "p4",
EmployeeId = "e4",
Type = "Literary Text"
},
new TransccriptionProgram {
    ProgramId = "p5",
    EmployeeId = "e5",
    Type = "Mathematical Text"
}
};

        static Employee[] employeeList = {
new Employee{
    EmployeeId = "e1",
    ProgramId = "p1",
    FirstName = "John",
    LastName = "Anderson"
    },
new Employee {
EmployeeId = "e2",
ProgramId = "p2",
FirstName = "Allisson",
LastName = "Jackson"
},
new Employee {
EmployeeId = "e3",
ProgramId = "p3",
FirstName = "Kate",
LastName = "Dodson"
},
new Employee {
    EmployeeId = "e4",
    ProgramId = "p1",
    FirstName = "Jacob",
    LastName = "Spurgeon"
},
new Employee {
EmployeeId = "e5",
ProgramId = "p2",
FirstName = "Cristina",
LastName = "Nelson"
}
        };

        static void addEmployees()
        {
            using (var dbContext = new TranscriptionDbContext())
            {
                dbContext.AddRangeAsync(employeeList);
                dbContext.SaveChanges();
            }
        }


        static void addPrograms()
        {
            using (var dbContext = new TranscriptionDbContext())
            {
                dbContext.AddRangeAsync(programList);
                dbContext.SaveChanges();
            }
        }

        static void retrieveData()
        {
            using (var dbContext = new TranscriptionDbContext())
            {
                var query = from employee in dbContext.Set<Employee>()
                            join program in dbContext.Set<TransccriptionProgram>()
                            on employee.EmployeeId equals program.EmployeeId
                select new { employee, program };
                foreach (var q in query)
                {
                    Console.WriteLine(q.employee.FirstName+" "+q.employee.LastName+" "+q.program.Type);
                }
            }
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Adding data...");
            addPrograms();
            addEmployees();
            Console.WriteLine("Finished adding data.");
            */
retrieveData();
        }
    }
}
