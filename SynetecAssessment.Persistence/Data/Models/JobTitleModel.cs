namespace SynetecAssessmentApi.Persistence.Data.Models
{
    public class JobTitleModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public JobTitleModel(
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
