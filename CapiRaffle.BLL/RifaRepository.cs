using CapiRaffle.MODEL;
namespace CapiRaffle.BLL
{
    public static class RifaRepository
    {
        public static void Add(Rifa _rifa)
        {

            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_rifa);
                dbContext.SaveChanges();
            }
        }

        public static Rifa GetById(int Id)
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                var rifa = dbContext.Rifas.Single(p => p.Id == Id);
                return rifa;
            }
        }

        public static List<Rifa> GetAll()
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                var rifa = dbContext.Rifas.ToList();
                return rifa;
            }
        }

        public static void Update(Rifa _rifa)
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                var rifa = dbContext.Rifas.Single(p => p.Id == _rifa.Id);
                rifa.NomeCriador = _rifa.NomeCriador;
                rifa.CpfCriador = _rifa.CpfCriador;
                rifa.PixCriador = _rifa.PixCriador;
                rifa.NomeRifa = _rifa.NomeRifa;
                rifa.PremioRifa = _rifa.PremioRifa;
                rifa.ValorRifa = _rifa.ValorRifa;
                rifa.DataTermino = _rifa.DataTermino;
                dbContext.SaveChanges();
            }
        }

        public static void Excluir(Rifa _rifa)
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                var rifa = dbContext.Rifas.Single(p => p.Id ==_rifa.Id);
                dbContext.Remove(rifa);
                dbContext.SaveChanges();
            }
        }
        public static Rifa GetByName(string name)
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                var rifa = dbContext.Rifas.Single(p => p.NomeRifa == name);
                return rifa;
            }
        }
    }
}