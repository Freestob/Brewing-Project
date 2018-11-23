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
    public class GrainsController : ApiController
    {
        private BrewerDbContext db = new BrewerDbContext();

        // GET: api/Grains
        public IQueryable<Grain> GetGrains()
        {
            return db.Grains;
        }

        // GET: api/Grains/5
        [ResponseType(typeof(Grain))]
        public IHttpActionResult GetGrain(int id)
        {
            Grain grain = db.Grains.Find(id);
            if (grain == null)
            {
                return NotFound();
            }

            return Ok(grain);
        }

        // PUT: api/Grains/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGrain(int id, Grain grain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != grain.Id)
            {
                return BadRequest();
            }

            db.Entry(grain).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrainExists(id))
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

        // POST: api/Grains
        [ResponseType(typeof(Grain))]
        public IHttpActionResult PostGrain(Grain grain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Grains.Add(grain);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = grain.Id }, grain);
        }

        // DELETE: api/Grains/5
        [ResponseType(typeof(Grain))]
        public IHttpActionResult DeleteGrain(int id)
        {
            Grain grain = db.Grains.Find(id);
            if (grain == null)
            {
                return NotFound();
            }

            db.Grains.Remove(grain);
            db.SaveChanges();

            return Ok(grain);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GrainExists(int id)
        {
            return db.Grains.Count(e => e.Id == id) > 0;
        }
    }
}