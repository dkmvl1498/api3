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
using api3.Models;

namespace api3.Controllers
{
    public class tblAccountsController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/tblAccounts
        public IQueryable<tblAccount> GettblAccounts()
        {
            return db.tblAccounts;
        }

        // GET: api/tblAccounts/5
        [ResponseType(typeof(tblAccount))]
        public IHttpActionResult GettblAccount(int id)
        {
            tblAccount tblAccount = db.tblAccounts.Find(id);
            if (tblAccount == null)
            {
                return NotFound();
            }

            return Ok(tblAccount);
        }

        // PUT: api/tblAccounts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAccount(int id, tblAccount tblAccount)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAccount.idAcc)
            {
                return BadRequest();
            }

            db.Entry(tblAccount).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAccountExists(id))
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

        // POST: api/tblAccounts
        [ResponseType(typeof(tblAccount))]
        public IHttpActionResult PosttblAccount(tblAccount tblAccount)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAccounts.Add(tblAccount);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblAccount.idAcc }, tblAccount);
        }

        // DELETE: api/tblAccounts/5
        [ResponseType(typeof(tblAccount))]
        public IHttpActionResult DeletetblAccount(int id)
        {
            tblAccount tblAccount = db.tblAccounts.Find(id);
            if (tblAccount == null)
            {
                return NotFound();
            }

            db.tblAccounts.Remove(tblAccount);
            db.SaveChanges();

            return Ok(tblAccount);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAccountExists(int id)
        {
            return db.tblAccounts.Count(e => e.idAcc == id) > 0;
        }
    }
}