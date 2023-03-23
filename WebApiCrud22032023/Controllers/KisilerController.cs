using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCrud22032023.Data;

namespace WebApiCrud22032023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KisilerController : ControllerBase
    {
        private readonly UygulamaDbContext _db;

        public KisilerController(UygulamaDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public List<Kisi> GetKisiler()
        {
            return _db.Kisiler.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult <Kisi> GetKisi(int id)
        {
            Kisi? kisi = _db.Kisiler.Find(id);
            if (kisi == null)
            {
                return NotFound();
            }
            return kisi;
        }

        [HttpPost]
        public ActionResult <Kisi> PostKisi(Kisi kisi)
        {
            if(ModelState.IsValid)
            {
                _db.Kisiler.Add(kisi);
                _db.SaveChanges();
                return kisi;
            }
            return BadRequest(ModelState);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteKisi(int id)
        {
            Kisi? kisi = _db.Kisiler.Find(id);

            if (kisi == null)
                return NotFound();

            _db.Remove(kisi);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult PutKisi(int id, Kisi kisi)
        {
            if (id != kisi.Id)
                return BadRequest();

            if (!_db.Kisiler.Any(x => x.Id == id))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _db.Update(kisi);
            _db.SaveChanges();
            return Ok();
        }
    }
}
