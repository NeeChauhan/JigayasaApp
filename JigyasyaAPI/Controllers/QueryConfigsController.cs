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
using JigyasyaAPI.Models;

namespace JigyasyaAPI.Controllers
{
    public class QueryConfigsController : ApiController
    {
        private GI365_JMSCoreV3Entities db = new GI365_JMSCoreV3Entities();

        // GET: api/QueryConfigs
        public IQueryable<QueryConfig> GetQueryConfigs()
        {
            return db.QueryConfigs;
        }

        // GET: api/QueryConfigs/5
        [ResponseType(typeof(QueryConfig))]
        public IHttpActionResult GetQueryConfig(Guid id)
        {
            QueryConfig queryConfig = db.QueryConfigs.Find(id);
            if (queryConfig == null)
            {
                return NotFound();
            }

            return Ok(queryConfig);
        }

        // PUT: api/QueryConfigs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutQueryConfig(Guid id, QueryConfig queryConfig)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != queryConfig.Id)
            {
                return BadRequest();
            }

            db.Entry(queryConfig).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QueryConfigExists(id))
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

        // POST: api/QueryConfigs
        [ResponseType(typeof(QueryConfig))]
        public IHttpActionResult PostQueryConfig(QueryConfig queryConfig)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.QueryConfigs.Add(queryConfig);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (QueryConfigExists(queryConfig.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = queryConfig.Id }, queryConfig);
        }

        // DELETE: api/QueryConfigs/5
        [ResponseType(typeof(QueryConfig))]
        public IHttpActionResult DeleteQueryConfig(Guid id)
        {
            QueryConfig queryConfig = db.QueryConfigs.Find(id);
            if (queryConfig == null)
            {
                return NotFound();
            }

            db.QueryConfigs.Remove(queryConfig);
            db.SaveChanges();

            return Ok(queryConfig);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool QueryConfigExists(Guid id)
        {
            return db.QueryConfigs.Count(e => e.Id == id) > 0;
        }
    }
}