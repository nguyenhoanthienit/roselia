using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Data.Context
{
	public class WriteDbContext : ApplicationContext
	{
		public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
		{

		}
	}
}
