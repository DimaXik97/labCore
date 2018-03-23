namespace CarService.Repository.Interfaces
{
    public interface IRepositoryContextFactory
    {
		RepositoryContext CreateDbContext(string connectionString);

	}
}