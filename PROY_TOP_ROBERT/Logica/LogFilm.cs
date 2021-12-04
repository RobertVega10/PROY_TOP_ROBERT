using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROY_TOP_ROBERT.Logica
{
    public class LogFilm
    {
        
        private static Repository.sakilaDbContext elContexto = new Repository.sakilaDbContext();

        public Models.Film BuscarPorId(int customerId)
        {
            Models.Film resultado;
            // resultado = elContexto.Customers.Find(customerId);
            resultado = elContexto.Films.Where(c => c.FilmId == customerId).FirstOrDefault();
            return resultado;
        }

        public IList<Models.Film> BuscarPorNombreAproximadoDelTitle(string nombreAproximadoDelTitulo)
        {
            IList<Models.Film> resultado;
            using (var _elContexto = new Repository.sakilaDbContext())
            {
                var laConsulta = _elContexto.Films.Include(c => c.FilmText).ThenInclude(ca => ca.FilmList).Where(c => c.FilmText.Any(ca => ca.FilmList.Title.Contains(nombreAproximadoDelTitulo))).OrderByDescending(c => c.FilmId);
                resultado = laConsulta.ToList();
            }
            return resultado;
        }

        public IList<Models.Film> BuscarPorNombreAproximadoConErrores(string nombreAproximado)
        {
            IList<Models.Film> resultado;
            using (var _elContexto = new Repository.sakilaDbContext())
            {
                resultado = _elContexto.Films.Where(c => c.Description.Contains(nombreAproximado)).OrderByDescending(c => c.FilmId).ToList();
            }
            return resultado;
        }

        public IList<Models.Film> BuscarPorNombreAproximado(string nombreAproximado)
        {
            IList<Models.Film> temporal;
            using (var _elContexto = new Repository.sakilaDbContext())
            {
                temporal = _elContexto.Films.OrderByDescending(c => c.FilmId).ToList().Where(c => c.Description.Contains(nombreAproximado)).ToList();
            }
            var resultado = temporal;
            return resultado;
        }
        

    }
        
}
