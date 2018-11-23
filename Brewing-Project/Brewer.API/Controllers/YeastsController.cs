using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Brewer.API.DAL;
using Brewer.API.Models;

namespace Brewer.API.Controllers
{
    public class YeastsController : ApiController
    {
        private BrewerDbContext db = new BrewerDbContext();

        // GET: api/Yeasts
        public IQueryable<Yeast> GetYeasts()
        {
            return db.Yeasts;
        }

        // GET: api/Yeasts/5
        [ResponseType(typeof(Yeast))]
        public IHttpActionResult GetYeast(int id)
        {
            Yeast yeast = db.Yeasts.Find(id);
            if (yeast == null)
            {
                return NotFound();
            }

            return Ok(yeast);
        }

        // PUT: api/Yeasts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutYeast(int id, Yeast yeast)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != yeast.Id)
            {
                return BadRequest();
            }

            db.Entry(yeast).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YeastExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Yeasts
        [ResponseType(typeof(Yeast))]
        public IHttpActionResult PostYeast(Yeast yeast)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Yeasts.Add(yeast);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = yeast.Id }, yeast);
        }

        // DELETE: api/Yeasts/5
        [ResponseType(typeof(Yeast))]
        public IHttpActionResult DeleteYeast(int id)
        {
            Yeast yeast = db.Yeasts.Find(id);
            if (yeast == null)
            {
                return NotFound();
            }

            db.Yeasts.Remove(yeast);
            db.SaveChanges();

            return Ok(yeast);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool YeastExists(int id)
        {
            return db.Yeasts.Count(e => e.Id == id) > 0;
        }
    }
}