using MegaCentralFinanceBackend.Data;
using MegaCentralFinanceBackend.Requests;
using MegaCentralFinanceBackend.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MegaCentralFinanceBackend.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class BPKBController : ControllerBase
    {
        public readonly ApplicationDBContext _dbContext;

        public BPKBController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("SubmitBPKBForm")]
        [HttpPost, AllowAnonymous]
        public BPKBFormResponse SubmitBPKBForm([FromBody] BPKBFormRequest request)
        {
            try
            {
                var obj = new Models.tr_bpkb 
                { 
                    agreement_number = request.AgreementNumber,
                    bpkb_no = request.BPKBNo,
                    branch_id = request.BranchID,
                    bpkb_date = request.BPKBDate,
                    faktur_no = request.FakturNo,
                    faktur_date = request.FakturDate,
                    location_id = request.LocationID,   
                    police_no = request.PoliceNo,
                    bpkb_date_in = request.BPKBIn,
                    createdBy = "SYSTEM",
                    created_on = DateTime.Now,
                    last_updated_by = "SYSTEM",
                    last_updated_on = DateTime.Now,
                };
                _dbContext.Add(obj);
                _dbContext.SaveChanges();
                return new BPKBFormResponse { SubmitSuccess = true, Message = "Success Submit Form BPKB"};
            }
            catch (Exception ex)
            {
                return new BPKBFormResponse { SubmitSuccess = false, Message = ex.Message};
            }
        }
    }
}
