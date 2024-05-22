namespace backend.Core.Dtos.Candidate
{
    public class CandidateGetDto
    {
        public long ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string CoverLetter { get; set; } = string.Empty;
        public string ResumeUrl { get; set; } = string.Empty;
        public long JobId { get; set; }
        public string JobTitle { get; set; } = string.Empty;
    }
}
