namespace WebApplication1
{
    public class SuperHero
    {
        private string name;

        public int Id { get; set; }
        [MaxLength(100)]
        public string? Name { get => name; set => name = value; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime Jdate { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public bool Status { get; set; }




    }
}
