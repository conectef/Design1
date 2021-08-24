namespace Design1.vscode.EF
{
       public class FrotaContext : DbContext
    {
        public FrotaContext(DbContextOptions<FrotaContext> options)
           : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
     
    }
}