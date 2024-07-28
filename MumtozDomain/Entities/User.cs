using MumtozDomain.Enums;

namespace MumtozDomain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string TellNumber {  get; set; }
        public UserRole Role { get; set; }
    }
}
