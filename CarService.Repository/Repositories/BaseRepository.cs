using CarService.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarService.Repository.Repositories
{
    public abstract class BaseRepository
    {
        protected string ConnectionString { get; }
		protected IRepositoryContextFactory ContextFactory { get; }
		public BaseRepository(string connectionString, IRepositoryContextFactory contextFactory)
        {
            ConnectionString = connectionString;
			ContextFactory = contextFactory;
        }
    }
}
