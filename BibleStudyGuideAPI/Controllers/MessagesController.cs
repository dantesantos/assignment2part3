﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibleStudyGuideAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BibleStudyGuideAPI.Controllers
{
    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        // connect
        DbModel db;

        public MessagesController(DbModel db)
        {
            this.db = db;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Message> Get()
        {
            return db.Messages.OrderBy(p => p.MessageID).ToList();
        }


        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var message = db.Messages.SingleOrDefault(p => p.MessageID == id);

            if (message == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(message);
            }
        }


        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
