using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Repositories.Interface;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CodePulse.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        //inject DbContext
        public ApplicationBbContext dbcontext;
        public CategoryRepository(ApplicationBbContext _dbcontext)
        {
            dbcontext = _dbcontext; 
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await dbcontext.Categories.AddAsync(category);
            await dbcontext.SaveChangesAsync();
            return category;
        }
    }
}
