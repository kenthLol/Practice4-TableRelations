using Microsoft.EntityFrameworkCore;

namespace P4TableRelations.Models {
    public class SocialMediaContext : DbContext {
        public SocialMediaContext(DbContextOptions<SocialMediaContext> options) : base (options) { }

        
    }
}