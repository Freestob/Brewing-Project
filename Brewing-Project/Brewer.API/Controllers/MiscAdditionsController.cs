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
    public class MiscAdditionsController : ApiController
    {
        private BrewerDbContext db = new BrewerDbContext();

        // GET: api/MiscAdditions
        public IQueryable<MiscAddition> GetMiscAdditions()
        {
            return db.MiscAdditions;
        }

        // GET: api/MiscAdditions/5
        [ResponseType(typeof(MiscAddition))]
        public IHttpActionResult GetMiscAddition(int id)
        {
            MiscAddition miscAddition = db.MiscAdditions.Find(id);
            if (miscAddition == null)
            {
                return NotFound();
            }

            return Ok(miscAddition);
        }

        // PUT: api/MiscAdditions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMiscAddition(int id, MiscAddition miscAddition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != miscAddition.Id)
            {
                return BadRequest();
            }

            db.Entry(miscAddition).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiscAdditionExists(id))
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

        // POST: api/MiscAdditions
        [ResponseType(typeof(MiscAddition))]
        public IHttpActionResult PostMiscAddition(MiscAddition miscAddition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MiscAdditions.Add(miscAddition);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = miscAddition.Id }, miscAddition);
        }

        // DELETE: api/MiscAdditions/5
        [ResponseType(typeof(MiscAddition))]
        public IHttpActionResult DeleteMiscAddition(int id)
        {
            MiscAddition miscAddition = db.MiscAdditions.Find(id);
            if (miscAddition == null)
            {
                return NotFound();
            }

            db.MiscAdditions.Remove(miscAddition);
            db.SaveChanges();

            return Ok(miscAddition);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MiscAdditionExists(int id)
        {
            return db.MiscAdditions.Count(e => e.Id == id) > 0;
        }
    }
}