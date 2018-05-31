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
using Asset.Model;

using Asset.Service;
using System.Web.Http.Cors;

namespace Asset.WebAPI.Controllers
{
   
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService _DepartmentService;
        public DepartmentController(IDepartmentService DepartmentService)
        {
            _DepartmentService = DepartmentService;
        }
        // GET: api/Department
       
        [HttpGet]
        public List<Department> GetAllDepartment()
        {
            return _DepartmentService.GetAll();
        }

        // GET: api/Department/5
      
        [HttpGet]
        [ResponseType(typeof(Department))]
        public Department GetDepartment(int id)
        {
            Department s_Department = _DepartmentService.GetById(id);
            

            return s_Department;
        }

        // PUT: api/Department/5
     
        [HttpPost]
        [ResponseType(typeof(void))]
        public IHttpActionResult AddDepartment( Department s_Department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            

           

                _DepartmentService.Add(s_Department);
           

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Department
       
        [HttpPut]
        [ResponseType(typeof(Department))]
        public IHttpActionResult UpdateDepartment(Department s_Department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _DepartmentService.Update(s_Department);

            return CreatedAtRoute("DefaultApi", new { id = s_Department.DepartmentID }, s_Department);
        }

        // DELETE: api/Department/5
     
        [HttpDelete]
        [ResponseType(typeof(Department))]
        public IHttpActionResult DeleteDepartment(int id)
        {
            Department s_Department = _DepartmentService.GetById(id);
            if (s_Department == null)
            {
                return NotFound();
            }

            _DepartmentService.Delete(s_Department);

            return Ok(s_Department);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
       
        [HttpGet]
        public bool IsDepartmentExists(string Name)
        {
            return _DepartmentService.FindByName(Name).Count() > 0;
        }
        [HttpGet]
        public bool IsDepartmentExistsWithID(int id,string Name)
        {
            return _DepartmentService.FindByName(Name).Where(x=>x.DepartmentID!=id).Count() > 0;
        }
    }
}