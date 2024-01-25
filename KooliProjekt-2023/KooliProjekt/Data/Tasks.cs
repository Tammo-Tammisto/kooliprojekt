namespace KooliProjekt.Data;
using FluentValidation;
using System.Diagnostics.CodeAnalysis;

public class Tasks
    {   
        public string Id { get; set; }

        public string Title { get; set; }

        public string TaskStart { get; set; }

        public string ExpectedTime { get; set; }

        public string InCharge { get; set; }

        public string Describtion { get; set; }

        public string WorkDone { get; set; }

        public string Files { get; set; }
    }
public class TasksValidator : AbstractValidator<Tasks>
{
    public TasksValidator() 
    {
        RuleFor(x => x.Id).NotNull();
        RuleFor(x => x.Title).NotNull();
        RuleFor(x => x.TaskStart).NotNull();
        RuleFor(x => x.ExpectedTime).NotNull();
        RuleFor(x => x.InCharge).NotNull();
        RuleFor(x => x.Describtion).NotNull();
        RuleFor(x => x.WorkDone).NotNull();
        RuleFor(x => x.Files).NotNull();
    }
}