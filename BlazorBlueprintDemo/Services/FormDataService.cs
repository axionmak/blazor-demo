namespace BlazorBlueprintDemo.Services;

public class FormSubmission
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public DateTime? DateOfBirth { get; set; }
    public bool AcceptTerms { get; set; }
    public string FavoriteColor { get; set; } = string.Empty;
    public bool ReceiveNewsletter { get; set; }
    public int Satisfaction { get; set; } = 5;
    public string ExperienceLevel { get; set; } = string.Empty;
    public DateTime SubmittedAt { get; set; }
}

public class FormDataService
{
    private readonly List<FormSubmission> _submissions = new();

    public void AddSubmission(FormSubmission submission)
    {
        submission.SubmittedAt = DateTime.Now;
        _submissions.Add(submission);
    }

    public IReadOnlyList<FormSubmission> GetAllSubmissions()
    {
        return _submissions.AsReadOnly();
    }

    public int GetSubmissionCount()
    {
        return _submissions.Count;
    }
}
