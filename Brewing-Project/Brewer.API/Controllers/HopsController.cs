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
    public class HopsController : ApiController
    {
        private BrewerDbContext db = new BrewerDbContext();

        // GET: api/Hops
        public IQueryable<Hop> GetHops()
        {
            return db.Hops;
        }

        // GET: api/Hops/5
        [ResponseType(typeof(Hop))]
        public IHttpActionResult GetHop(int id)
        {
            Hop hop = db.Hops.Find(id);
            if (hop == null)
            {
                return NotFound();
            }

            return Ok(hop);
        }

        // PUT: api/Hops/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHop(int id, Hop hop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hop.Id)
            {
                return BadRequest();
            }

            db.Entry(hop).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HopExists(id))
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

        // POST: api/Hops
        [ResponseType(typeof(Hop))]
        public IHttpActionResult PostHop(Hop hop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Hops.Add(hop);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hop.Id }, hop);
        }

        // DELETE: api/Hops/5
        [ResponseType(typeof(Hop))]
        public IHttpActionResult DeleteHop(int id)
        {
            Hop hop = db.Hops.Find(id);
            if (hop == null)
            {
                return NotFound();
            }

            db.Hops.Remove(hop);
            db.SaveChanges();

            return Ok(hop);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HopExists(int id)
        {
            return db.Hops.Count(e => e.Id == id) > 0;
        }
    }
}