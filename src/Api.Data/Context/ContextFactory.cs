using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace src.Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para criar migrações - Tempo de design

            //mySQL
            var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=Chico@1234";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionString);

            //SQLServer
            // var connectionString = "Data Source= .;Initial Catalog=dbapi;User ID=sa;Password=Chico@1234";
            // var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            // optionsBuilder.UseSqlServer(connectionString);

            return new MyContext(optionsBuilder.Options);
        }
    }
}
