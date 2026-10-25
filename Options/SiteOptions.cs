namespace Gachlab.Consulting.Site.Options;

public sealed class SiteOptions
{
    public const string SectionName = "Site";

    /// <summary>Google Calendar Appointment Schedule URL (empty = mailto fallback).</summary>
    public string CalendarUrl { get; set; } = "";

    public string Email { get; set; } = "gach87@gmail.com";

    public string UpworkUrl { get; set; } = "";
    public string WorkanaUrl { get; set; } = "";
    public string GitHubUrl { get; set; } = "";
    public string LinkedInUrl { get; set; } = "";
}
