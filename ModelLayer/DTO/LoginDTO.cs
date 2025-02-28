namespace ModelLayer.DTO
{
    public class LoginDTO
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Password { get; set; }

        public string ToString()
        {
            return FirstName+" "+LastName+" : "+Email;
        }
    }
}
