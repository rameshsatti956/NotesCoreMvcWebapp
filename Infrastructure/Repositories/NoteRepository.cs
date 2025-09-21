using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly NoteDbContext _context;

        public NoteRepository(NoteDbContext context)
        {
            _context = context;
        }

        public async Task<List<Note>> GetAllAsync() => await _context.Notes.OrderByDescending(x=>x.Id).ToListAsync();
        public async Task<Note?> GetByIdAsync(int id) => await _context.Notes.FindAsync(id);
        public async Task AddAsync(Note note)
        {
            _context.Notes.Add(note);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Note note)
        {
            _context.Notes.Update(note);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var note = await _context.Notes.FindAsync(id);
            if (note != null)
            {
                _context.Notes.Remove(note);
                await _context.SaveChangesAsync();
            }
        }
    }
}
