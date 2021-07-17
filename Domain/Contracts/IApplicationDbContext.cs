﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Contracts
{
	public interface IApplicationDbContext
	{
		//ChangeTracker ChangeTracker { get; }
		//IModel Model { get; }
		DbSet<TEntity> Set<TEntity>() where TEntity : class;
	}
}
