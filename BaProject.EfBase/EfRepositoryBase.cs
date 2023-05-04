using BaProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BaProject.EfBase
{
	public class EfRepositoryBase<TContext, TEntity> : ISelectableRepo<TEntity>, ISelectableRepoAsync<TEntity>, IInsertableRepo<TEntity>, IInsertableRepoAsync<TEntity>, IUpdatableRepo<TEntity>, IDeletableRepo<TEntity> 
		where TEntity : class, IEntity
	where TContext : DbContext, new()
	{
		private readonly TContext _context;
		public EfRepositoryBase()
		{
			_context = new TContext();
		}
		/// <summary>
		/// uof a tam uygunluk bu overload uzerinden gerceklesir
		/// </summary>
		/// <param name="context"></param>
		public EfRepositoryBase(TContext context)
		{
			_context = context;
		}
		public TEntity Add(TEntity entity)
		{
			_context.Set<TEntity>().Add(entity);
			return entity;
		}
		public async Task AddAsync(TEntity entity)
		{
			await _context.Set<TEntity>().AddAsync(entity);
		}

		public async Task AddRangeAsync(List<TEntity> entities)
		{
			await _context.Set<TEntity>().AddRangeAsync(entities);
		}

		public List<TEntity> AddRange(List<TEntity> entities)
		{
			_context.Set<TEntity>().AddRange(entities);
			return entities;
		}

		public List<TEntity> GetAll()
		{
			return _context.Set<TEntity>().ToList();
		}

		public async Task<List<TEntity>> GetAllAsync()
		{
			return await _context.Set<TEntity>().ToListAsync();
		}

		public List<TEntity> GetBy(Func<TEntity, bool> condition)
		{
			return _context.Set<TEntity>().Where(condition).ToList();
		}

		public TEntity GetById(object id)
		{
			return _context.Set<TEntity>().Find(id);
		}

		public async Task<TEntity> GetByIdAsync(object id)
		{
			return await _context.Set<TEntity>().FindAsync(id);
		}

		public void MySaveChanges()
		{
			_context.SaveChanges();
		}

		public void Update(TEntity entity)
		{
			_context.Set<TEntity>().Update(entity);

			//_context.Entry(entity).State = EntityState.Modified;
			//_context.Set<TEntity>().Attach(entity);
		}

		public void Delete(TEntity entity)
		{
			_context.Set<TEntity>().Remove(entity);
		}
	}
}
