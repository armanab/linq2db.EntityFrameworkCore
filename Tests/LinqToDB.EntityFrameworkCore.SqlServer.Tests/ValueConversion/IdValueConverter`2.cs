﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LinqToDB.EntityFrameworkCore.SqlServer.Tests.ValueConversion
{
	public sealed class IdValueConverter<TKey, TEntity> : ValueConverter<Id<TEntity, TKey>, TKey>
		where TEntity : IEntity<TKey>
	{
		public IdValueConverter(ConverterMappingHints mappingHints = null)
			: base(id => id.Value, key => new Id<TEntity, TKey>(key)) { }
	}
	
	public sealed class IdValueConverter<TEntity> : ValueConverter<Id<TEntity, long>, long>
		where TEntity : IEntity<long>
	{
		public IdValueConverter(ConverterMappingHints mappingHints = null)
			: base(id => id.Value + 1, key => new Id<TEntity, long>(key - 1)) { }
	}	
}
