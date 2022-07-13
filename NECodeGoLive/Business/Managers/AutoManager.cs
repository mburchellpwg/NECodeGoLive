using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace Business.Managers
{
    public class AutoManager : IAutoManager
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AutoManager(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<AutoVM> CreateAsync(AutoVM obj)
        {
            var auto =_mapper.Map<AutoVM, Auto>(obj);
            var autoAdded = await _context.Autos.AddAsync(auto);
            await _context.SaveChangesAsync();
            return _mapper.Map<Auto, AutoVM>(autoAdded.Entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AutoVM>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<AutoVM> GetAsync(int id)
        {
            var autoInfo = await _context.Autos.FirstOrDefaultAsync((x => x.Id == id));

            if(autoInfo == null)
            {
                return null;
            }

            return _mapper.Map<AutoVM>(autoInfo);
        }

        public async Task<AutoVM> UpdateAsync(AutoVM obj)
        {
            throw new NotImplementedException();

        }
    }
}
