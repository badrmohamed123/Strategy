using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.infrastructur.persistences.Data
{
    public class ApplicationDb_ConText : DbContext
    {
        public ApplicationDb_ConText(DbContextOptions<ApplicationDb_ConText>options) : base (options)
        {
            
        }
    }
}
