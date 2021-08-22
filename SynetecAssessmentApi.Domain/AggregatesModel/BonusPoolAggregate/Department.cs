namespace SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate
{
    public class Department
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Department(
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