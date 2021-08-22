namespace SynetecAssessmentApi.Persistence.Data.DbContexts.DbInitializer
{
    public interface IDbInitializer
    {
        void Initialize();
        void SeedData();
    }
}
