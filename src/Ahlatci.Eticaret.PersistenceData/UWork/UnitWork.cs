﻿using Ahlatci.Eticaret.Application.Repositories;
using Ahlatci.Eticaret.Domain.Entities.Common;
using Ahlatci.Eticaret.Domain.UWork;
using Ahlatci.Eticaret.Persistence.Context;
using Ahlatci.Eticaret.Persistence.Repositories;

namespace Ahlatci.Eticaret.Persistence.UWork
{
    public class UnitWork : IUnitWork
    {
        private Dictionary<Type, object> _repositories;
        private readonly AhlatciContext _context;

        public UnitWork(AhlatciContext context)
        {
            _repositories = new Dictionary<Type, object>();
            _context = context;
        }

      
        // Bu UnitOfWork katmanında kayıtlı olan tüm repolar için tek seferde
        // db kayıt işlemini çalıştırır. Hata olursa buradan exception fırlatılır.
       
        public async Task<bool> CommitAsync()
        {
            var result = false;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                    result = true;
                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
            return result;
        }


        /// <summary>
        /// Yazılımcı hethangi bir repo üzerinde insert, update, delete veya select yapacaksa
        /// bu metod yardımıyla DI içerisinde kayıtlı ilgili entity için kullanılabilecek repoya erişir.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            //Daha önce bu repoyu talep eden bir kullanıcı olmuşsa aynı repoyu tekrar üretmez.
            //Burada sakladığı koleksiyon içerisinden gönderir. Bu da performansı artırır.
            if (_repositories.ContainsKey(typeof(IRepository<T>)))
            {
                return (IRepository<T>)_repositories[typeof(IRepository<T>)];
            }

            var repository = new Repository<T>(_context);
            _repositories.Add(typeof(IRepository<T>), repository);
            return repository;
        }


        #region Dispose

        bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                //.Net objelerini kaldır.
                _context.Dispose();
            }

            //Kullanılan harici dil kütüphaneleri (.Net ile yazılmamış external kütüphaneler)
            //Örneğin görüntü işlemi için kullanılacak bir C++ kütüphanesini bellekten at

            _disposed = true;
        }

        #endregion


    }
}

