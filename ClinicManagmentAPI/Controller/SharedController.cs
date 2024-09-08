using ClinicManagementAPI.Context;
using ClinicManagmentAPI_Repos.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ClinicManagementAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedController : ControllerBase
    {
        private readonly ClinicManagementDbContext _clinicManagementDbContext;
        public SharedController(ClinicManagementDbContext clinicManagementDbContext)
        {
            _clinicManagementDbContext=clinicManagementDbContext;
        }
        //Swagger - Docummentation 
        [HttpPost]
        [Route("[action]")]

        public async Task<IActionResult> TestMethod()
        {
            //declaration 
            try
            {

                Log.Information("TestMethod Started");
                //implementation - call repos layer
                LaborityTest laborityTest = new LaborityTest();
                laborityTest.Name = "Test";
                laborityTest.Purpose = "test";
                laborityTest.CreationDate= DateTime.Now;
                laborityTest.CreatorUser = "Test";
                laborityTest.IsDeleted = false;
                await _clinicManagementDbContext.AddAsync(laborityTest);
                await _clinicManagementDbContext.SaveChangesAsync();
                return Ok(_clinicManagementDbContext.LaborityTests.ToList());
            }catch (Exception ex)
            {
                Log.Error("TestMethod has been Stopped");
                Log.Error(ex.Message);
                return Unauthorized(ex.Message);
            }
        } 
    }

}
