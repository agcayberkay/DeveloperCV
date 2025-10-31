namespace DeveloperCV.Models;

public class ProfileModel
{
    public string PhotoUrl { get; set; } = "/img/profile.jpg";
    public string FullName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string? BirthDate { get; set; }
    public string? AgeText { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public SocialLinks Social { get; set; } = new();

    public List<string> Summary { get; set; } = new();
    public List<ExperienceItem> Experiences { get; set; } = new();
    public List<ProjectItem> Projects { get; set; } = new();
    public List<ReferenceItem> References { get; set; } = new();

    public EducationItem Education { get; set; } = new();
    public string MilitaryStatus { get; set; } = string.Empty;

    public SkillsBlock Skills { get; set; } = new();
    public List<string> SoftSkills { get; set; } = new();
    public List<string> Hobbies { get; set; } = new();
}

public class SocialLinks
{
    public string? LinkedIn { get; set; }
    public string? GitHub { get; set; }
}

public class ExperienceItem
{
    public string Title { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string DateRange { get; set; } = string.Empty;
    public List<string> Bullets { get; set; } = new();
}

public class ProjectItem
{
    public string Name { get; set; } = string.Empty;
    public string? Year { get; set; }
    public List<string> Bullets { get; set; } = new();
}

public class ReferenceItem
{
    public string Name { get; set; } = string.Empty;
    public string? Title { get; set; }
    public string? Company { get; set; }
    public string? Phone { get; set; }
}

public class EducationItem
{
    public string Program { get; set; } = string.Empty;
    public string School { get; set; } = string.Empty;
    public string? Year { get; set; }
    public string? GPA { get; set; }
}

public class SkillsBlock
{
    public List<string> ProgrammingLanguages { get; set; } = new();
    public List<string> Frameworks { get; set; } = new();
    public List<string> Databases { get; set; } = new();
    public List<string> Tools { get; set; } = new();
    public List<string> Other { get; set; } = new();
}
