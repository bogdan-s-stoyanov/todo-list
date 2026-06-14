using Microsoft.EntityFrameworkCore;

namespace TodoList.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {

        }
    }
}
