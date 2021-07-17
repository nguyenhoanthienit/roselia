using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Contracts
{
	public interface IRepositoryFactory
	{
		IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
	}
}
