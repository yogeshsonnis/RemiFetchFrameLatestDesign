using RemiFetchFrame.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiFetchFrame.Services
{
   public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _db;

        public DatabaseService()
        {
            var dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "RemiFetchDatabase.db3");

            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<CaseModel>().Wait();
        }

        // CREATE
        public Task<int> AddCaseAsync(CaseModel model)
        {
            return _db.InsertAsync(model);
        }

        // READ
        public Task<List<CaseModel>> GetCasesAsync()
        {
            return _db.Table<CaseModel>().ToListAsync();
        }

        // UPDATE
        public Task<int> UpdateCaseAsync(CaseModel model)
        {
            return _db.UpdateAsync(model);
        }

        // DELETE
        public Task<int> DeleteCaseAsync(CaseModel model)
        {
            return _db.DeleteAsync(model);
        }
    }
}
