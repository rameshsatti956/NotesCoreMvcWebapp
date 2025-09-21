using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface INoteService
    {
        public Task<List<Note>> GetAllAsync();
        public Task<Note?> GetByIdAsync(int id);
        public Task AddAsync(Note note);
        public Task UpdateAsync(Note note);
        public Task DeleteAsync(int id);

    }
}
