using Api_Project.Context;
using Api_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Api_Project.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        ApiDbContext _dbContext;
       


        public EmployeeController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
           
        }
        [HttpGet]
        public List<Employee>GetAll()

        {

            var employees = _dbContext.employees.FromSqlRaw("SELECT * FROM Employees").ToList();
            return employees;

        }
        [HttpGet]
        public List<Employee> Third_highest()

        {

            var employees = _dbContext.employees.FromSqlRaw("SELECT TOP 1 epmSalary FROM " +
                " (SELECT TOP 3 epmSalary " + "FROM Employees " +" ORDER BY epmSalary DESC) " +
                "AS Comp" + "ORDER BY epmSalary ASC ").ToList();
            return employees;

        }

        /*[HttpGet]
        public List<Employattendance> EmpSalary()

        {

            var empsalary =from e in _dbContext.employees.
                Join em in _dbContext.Employattendance on e.Id equals em.Id 
                where em.isAbsent = 1;
               return empsalary;

        }*/


        
    }
}
