namespace BlazorServer.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
            {
                new UserAccount{ UserName = "admin", Password = "admin", Role = "admin"},
                new UserAccount{ UserName = "mokytojas", Password = "mokytojas", Role = "mokytojas"},
                new UserAccount{ UserName = "mokinys", Password = "mokinys", Role = "mokinys"}
            };
        }

        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
