using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibleStudyGuideAPI.Models
{
    public class DbModel : DbContext
    {
        public DbModel(DbContextOptions<DbModel>options) : base(options)
        {

        }
        public virtual DbSet<Message> Messages { get; set; }
    }
}
