namespace KooliProjekt.Data;
using FluentValidation;
public class Project
{
    public string Id { get; set; }
    public string ProjectName { get; set; }
    public string Start { get; set; }
    public string Deadline { get; set; }
    public string Budget { get; set; }
    public string HourlyRate { get; set; }
    public string Team { get; set; }
}

public class ProjectValidator : AbstractValidator<Project>
{
    public ProjectValidator()
    {
        RuleFor(x => x.Id).NotNull();
        RuleFor(x => x.ProjectName).NotEmpty();
        RuleFor(x => x.Start).NotEmpty();
        RuleFor(x => x.Deadline).NotEmpty();
        RuleFor(x => x.Budget).NotEmpty();
        RuleFor(x => x.HourlyRate).NotEmpty();
        RuleFor(x => x.Team).NotEmpty();
    }
}

