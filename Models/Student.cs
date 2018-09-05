using System.Collections.Generic;
using Dapper;
using Microsoft.Data.Sqlite;

namespace nss.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> AssignedExercises { get; set; } = new List<Exercise>();

        public static void Seed(SqliteConnection db)
        {
            db.Execute($@"INSERT INTO Student
                SELECT null, 'William', 'Kimball', '@williamkimball',                               c.Id
                FROM Cohort c WHERE c.Name = 'Evening Cohort 1'
            ");
            db.Execute($@"INSERT INTO Student
                SELECT null, 'Robert', 'Leedy', '@robert', c.Id
                FROM Cohort c WHERE c.Name = 'Day Cohort 21'
            ");
            db.Execute($@"INSERT INTO Student
                SELECT null, 'Leah', 'Gwin', '@Leah', c.Id
                FROM Cohort c WHERE c.Name = 'Day Cohort 10'
            ");
        }

        
    }

}