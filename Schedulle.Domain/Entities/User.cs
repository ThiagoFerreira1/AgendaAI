using Core.Domain.Entities;

namespace Domain.Entities
{
    public enum UserType
    {
        Admin = 1,
        Guest = 3
    }

    public sealed class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
    }
}
