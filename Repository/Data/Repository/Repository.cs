﻿using BlissPollAPI.Repository;
using BlissPollAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace BlissPollAPI.Data.Repository
{
	public class Repository<T> : IRepository<T>, IDisposable where T : class
	{
		private DataContext _context;

		public Repository(DataContext context)
		{
			_context = context;
		}

		public async Task Create(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public async Task Delete(T entity)
		{
			_context.Set<T>().Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task<T> Get(int id)
		{
			return await _context.Set<T>().FindAsync(id);
		}

		public async Task<List<T>> GetAll()
		{
			var list = await _context.Set<T>().ToListAsync();
			return list;
		}

		public async Task Update(T entity)
		{
			_context.Set<T>().Update(entity);
			await _context.SaveChangesAsync();
		}

		#region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
		// Flag: Has Dispose already been called?
		bool disposed = false;
		// Instantiate a SafeHandle instance.
		SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);


		// Public implementation of Dispose pattern callable by consumers.
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Protected implementation of Dispose pattern.
		protected virtual void Dispose(bool disposing)
		{
			if (disposed)
				return;

			if (disposing)
			{
				handle.Dispose();
				// Free any other managed objects here.
				//
			}

			disposed = true;
		}
		#endregion
	}
}
