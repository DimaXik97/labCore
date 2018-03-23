using CarService.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarService.Repository.Factories
{
	public class RepositoryContextFactory : IRepositoryContextFactory
	{
		public RepositoryContext CreateDbContext(string connectionString)
		{
			var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>();
			optionsBuilder.UseSqlServer(connectionString);

			return new RepositoryContext(optionsBuilder.Options);
		}
	}
}