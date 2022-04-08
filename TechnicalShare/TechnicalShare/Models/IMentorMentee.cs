namespace TechnicalShare.Models
{
    public interface IMentorMentee
    {
        Expertise Expertise { get; set; }
        Mentee Mentee { get; set; }
        int MenteeId { get; set; }
        Mentor Mentor { get; set; }
        int MentorId { get; set; }
    }
}