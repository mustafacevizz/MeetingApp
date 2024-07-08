namespace MeetingApp.Models
{
    public static class Repository
    {
        public static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo() { Id=1, Name = "Ali", Email = "ali@abc.com", Phone = "646321654", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Ahmet", Email = "ahmet@abc.com", Phone = "664654", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Ayşe", Email = "ayşe@abc.com", Phone = "456321654", WillAttend = false });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;

            _users.Add(user);
        }
        
        public static UserInfo? GetById(int id) //repositoryden idleri al
        {
            return _users.FirstOrDefault(user => user.Id == id);

        }
    }
}
