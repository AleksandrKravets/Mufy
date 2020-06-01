using System.Collections.Generic;

namespace Mufy.DAL
{
    public class UsersTable
    {
        public long Id { get; set; }
        public string Username { get; set; }
    }

    public static class Database
    {
        public static List<UsersTable> Users = new List<UsersTable>
        {
            new UsersTable
            {
                Id = 0, Username = "Aleks"
            },
            new UsersTable
            {
                Id = 1, Username = "Nick"
            },
            new UsersTable
            {
                Id = 2, Username = "Andrew"
            }
        };
    }
}
