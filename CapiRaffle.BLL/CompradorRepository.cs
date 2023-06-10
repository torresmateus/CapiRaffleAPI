

using CapiRaffle.MODEL;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace CapiRaffle.BLL
{
    public static class CompradorRepository
    {
        public static void Add(Comprador _comprador)
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_comprador);
                dbContext.SaveChanges();
            }
        }

        public static Comprador GetById(int Id)
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                var comprador = dbContext.Compradors.Single(p => p.Id == Id);
                return comprador;
            }
        }

        public static List<Comprador> GetAll()
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                var comprador = dbContext.Compradors.ToList();
                return comprador;
            }
        }

        public static void Update(Comprador _comprador)
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                var comprador = dbContext.Compradors.Single(p => p.Id == _comprador.Id);
                comprador.NomeComprador = _comprador.NomeComprador;
                comprador.CpfComprador = _comprador.CpfComprador;
                comprador.Numeros = _comprador.Numeros;
                dbContext.SaveChanges();
            }
        }

        public static void Excluir(Comprador _comprador)
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                var comprador = dbContext.Compradors.Single(p => p.Id == _comprador.Id);
                dbContext.Remove(comprador);
                dbContext.SaveChanges();
            }
        }

        public static Comprador GetByName(string name)
        {
            using (var dbContext = new CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext())
            {
                var comprador = dbContext.Compradors.Single(p => p.NomeComprador == name);
                return comprador;
            }
        }
    }
}
