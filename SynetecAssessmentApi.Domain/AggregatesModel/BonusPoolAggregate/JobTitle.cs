namespace SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public JobTitle(
            int id,
            string title,
            string description)
        {
            Id = id;
            Title = title;
            Description = description;

        }

    }
}
