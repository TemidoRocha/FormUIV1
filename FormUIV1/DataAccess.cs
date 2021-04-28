using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUIV1
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            // when we use using as bellow, as soon as the function ends the connection ends
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CmVal("SampleDB")))
            {
                /* 
                 * NOT GOOD PRACTICE AND SUSCEPTIBLE TO INJECTION
                 * return connection.Query<Person>($"SELECT * FROM People WHERE LastName = '{ lastName }'").ToList();
                 * 
                 */
                return connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
            }
        }

        internal void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CmVal("SampleDB")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });

                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }
    }
}
