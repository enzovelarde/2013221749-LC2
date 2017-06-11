using _2013221749_ENT.Entities;
using _2013221749_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013221749_PER.Repositories
{
    public class VolanteRepository : Repository<Volante>, IVolanteRepository
    {
        public VolanteRepository(EnsambladoraDbContext context) : base(context)
        {
           
        }

    }
}
