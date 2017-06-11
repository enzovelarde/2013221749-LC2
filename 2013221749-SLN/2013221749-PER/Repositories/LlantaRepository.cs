using _2013221749_ENT.Entities;
using _2013221749_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013221749_PER.Repositories
{
    public class LlantaRepository : Repository<Llanta>, ILlantaRepository
    {


        public LlantaRepository(EnsambladoraDbContext context) : base(context)
        {
   
        }

    }
}
