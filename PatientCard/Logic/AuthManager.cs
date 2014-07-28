namespace PatientCard.Logic
{
    public class AuthManager
    {
        public class User
        {
            public string Username { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
        }

        public static User CurrentUser { get; set; }
    }
}