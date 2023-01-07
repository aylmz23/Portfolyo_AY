namespace Portfolyo_AY.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set;}
        public string? UserEmail { get; set; }

        public int AppRoleId { get; set; }

        public AppRole AppRole { get; set; }
    }
}
