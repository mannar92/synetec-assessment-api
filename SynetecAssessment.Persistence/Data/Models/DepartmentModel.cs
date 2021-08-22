namespace SynetecAssessmentApi.Persistence.Data.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DepartmentModel(
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