namespace Sarms.Domain.Core
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string SName { get; set; }
        public int AccessLevel { get; private set; }
        public int Status { get; private set; }

        public void ChangeAccountAccess(int accessLevel)
        {
            AccessLevel = accessLevel;
        }

        public void ChangeAccountStatus(int status)
        {
            Status = status;
        }
    }
}
