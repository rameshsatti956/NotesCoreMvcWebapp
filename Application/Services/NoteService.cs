using Domain.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _notes;

        public NoteService(INoteRepository notes)
        {
            _notes = notes;
        }

        public Task<List<Note>> GetAllAsync() => _notes.GetAllAsync();
        public Task<Note?> GetByIdAsync(int id) => _notes.GetByIdAsync(id);
        public Task AddAsync(Note note) => _notes.AddAsync(note);
        public Task UpdateAsync(Note note) => _notes.UpdateAsync(note);
        public Task DeleteAsync(int id) => _notes.DeleteAsync(id);

    }
}
