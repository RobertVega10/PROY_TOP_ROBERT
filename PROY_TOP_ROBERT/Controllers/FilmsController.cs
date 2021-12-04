using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROY_TOP_ROBERT.Repository;
using PROY_TOP_ROBERT.DtoModels;
using PROY_TOP_ROBERT.Models;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTopicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly sakilaDbContext context;
        private readonly IMapper _mapper;

        public FilmsController(IMapper mapper)
        {
            _mapper = mapper;
            context = new sakilaDbContext();
        }


        // GET: api/Customers
        [HttpGet("{id}")]
        public async Task<ActionResult<DtoFilms>> Getfilms(int filmid)
        {
            var customerBD = (await context.Films.Include(c => c.FilmText).ThenInclude(ca=>ca.FilmList).Where(c => c.FilmId == filmid).ToListAsync()).FirstOrDefault();
            //var customerBD = await context.Films.FindAsync (filmid);

            if (customerBD == null)
            {
                return NotFound();
            }
            var customerResultante = _mapper.Map<DtoFilms>(customerBD);

            return customerResultante;
        }



        // POST api/<FilmsController>
        [HttpPost]
        public async Task<ActionResult<Film>> PostCustomer(Film fil)
        {
            context.Films.Add(fil);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetFilms", new { id = fil.FilmId }, fil);
        }

        // PUT api/<FilmsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilms(int id, Film films)
        {
            if (id != films.FilmId)
            {
                return BadRequest();
            }

            context.Entry(films).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!filmsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool filmsExists(int id)
        {
            return context.Films.Any(e => e.FilmId == id);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilms(int FilmId)
        {
            var films = await context.Films.FindAsync(FilmId);
            if (films == null)
            {
                return NotFound();
            }

            context.Films.Remove(films);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
