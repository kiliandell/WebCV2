using Microsoft.EntityFrameworkCore;
using WebCV2.Pages;
using WebCV2.models;

namespace WebCV2.Controllers
{
    public class DBManagement : DbContext
    {
        public DBManagement(DbContextOptions<DBManagement> options) : base(options)
        {
        }

        public DbSet<CompetencesModel> competences { get; set; }

        public DbSet<ExperiencesModel> experiences { get; set; }

        public DbSet<FormationsModel> formations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public async Task<List<CompetencesModel>> GetAllCompetences()
        {
            return await competences
                .AsNoTracking() 
                .ToListAsync()
                ;
        }

        public async Task<List<ExperiencesModel>> GetAllExperiences()
        {
            return await experiences
                .AsNoTracking()
                .OrderByDescending(x => x.idexperiences)
                .ToListAsync();
        }

        public async Task<List<FormationsModel>> GetAllFormations()
        {
            return await formations
                .AsNoTracking()
                .ToListAsync();
        }


    }
}
