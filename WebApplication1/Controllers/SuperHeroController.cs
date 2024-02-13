using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Net;
using System.Reflection;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        //private static List<SuperHero> heroes = new List<SuperHero>
          //  {
                //new SuperHero {
                  //  Id = 1,
                  //  Name = "Spider Man",
                  //  FirstName = "Peter",
                  //  LastName = "Parker",
                  //  Place = "New York City"
                //},
                //new SuperHero {
                //    Id = 2,
                //    Name = "Iron Man",
                //    FirstName = "Tony",
                //    LastName = "Stark",
                //    Place = "Long Island"
               // }
           // };
        private readonly DataContext context;
       

        public SuperHeroController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return Ok(await this.context.SuperHeroes.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> Get(int id)
        {
            var hero = await this.context.SuperHeroes.FindAsync(id);
            if (hero == null)
                return BadRequest("Hero Not Found");
            return Ok(hero);
        }
        [HttpGet("search")]
        public async Task<IActionResult> GetEmployee(int id, string name, string role)
        {
            if (id == 0 && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(role))
            {
                return Ok(await this.context.SuperHeroes.ToListAsync());
            }
            var result =  this.context.SuperHeroes as IQueryable<SuperHero>;
            if (id != 0)
            {
                result = result.Where(x => x.Id == id);
            }
            if (!string.IsNullOrEmpty(name))
            {
                result = result.Where(x => x.Name == name);
            }
            if (!string.IsNullOrEmpty(role))
            {
                result = result.Where(x => x.Role == role);
            }

            return Ok(result);




           // if (!result)
           // {
           //     return BadRequest("NNN");
           // }
           // return Ok(result);
        }
    

       [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            this.context.SuperHeroes.Add(hero);
            await this.context.SaveChangesAsync();
            return Ok(hero);
        }
        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero request)
        {

            
            var DbHero = await this.context.SuperHeroes.FindAsync(request.Id);
            if (DbHero == null)
                return BadRequest("Hero Not Found");
            DbHero.Name= request.Name;
            DbHero.FirstName= request.FirstName;
            DbHero.LastName= request.LastName;
            DbHero.Username= request.Username;
            DbHero.Password= request.Password;
            DbHero.Email= request.Email;
            DbHero.Phone= request.Phone;
            DbHero.Role= request.Role;
            DbHero.Jdate= request.Jdate;
            DbHero.Status= request.Status;
            await this.context.SaveChangesAsync();
            return Ok(DbHero);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> Delete(int id)
        {
            var DbHero = await this.context.SuperHeroes.FindAsync(id);
            if (DbHero == null)
                return BadRequest("Hero Not Found");
            this.context.SuperHeroes.Remove(DbHero);
            await this.context.SaveChangesAsync();
            return Ok(await this.context.SuperHeroes.ToListAsync());
        }



    }
}
