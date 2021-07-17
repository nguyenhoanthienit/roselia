﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Entities
{
	public interface IBaseEntity<TKey>
	{
		[Key]
		public TKey Id { get; set; }
	}
}
