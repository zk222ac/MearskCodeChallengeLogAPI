namespace MearskCodeChallengeLogAPI.Models.Students
{
    public class Student : IAuditable
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public string? IdentityNumber { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public Gender Gender { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
