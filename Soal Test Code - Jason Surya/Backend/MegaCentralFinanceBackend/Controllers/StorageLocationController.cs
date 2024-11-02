using MegaCentralFinanceBackend.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MegaCentralFinanceBackend.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class StorageLocationController : ControllerBase
    {
        public readonly ApplicationDBContext _dbContext;
        public StorageLocationController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("GetStorageLocations")]
        [HttpGet, AllowAnonymous]
        public JsonResult StorageLocation() 
        {
            try
            {
                return new JsonResult(_dbContext.ms_storage_location);
            }
            catch (Exception ex) 
            {
                return new JsonResult(ex.Message);
            }
        }
    }
}
