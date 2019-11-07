namespace JForums.Models.User
{
    public class BaseProfile
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string ProfileImageUrl { get; set; }
        public int Rating { get; set; }
        public bool IsActive { get; set; }
    }
}
