using Butce.BusinessLayer.Abstract;
using Butce.DataAccessLayer.Abstract;
using Butce.DtoLayer.ApprovalDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApprovalController : ControllerBase
    {
        private readonly IApprovalService _approvalService; 
        
        public ApprovalController(IApprovalService approvalService)
        {
            _approvalService = approvalService; 
        }
        [HttpGet]
        public IActionResult ApprovalList() {
            var values = _approvalService.TGetAll();
            return Ok(values);
            }
        [HttpPost]
        public  IActionResult CreateApproval (CreateApprovalDto createApprovalDto)
        {
            Approval approval = new Approval()
            {
                ApprovalID = createApprovalDto.ApprovalID,
                CompanyID = createApprovalDto.CompanyID,
                WorkDoneID = createApprovalDto.WorkDoneID,
                WorkDoneTypeID = createApprovalDto.WorkDoneTypeID,
                VATID = createApprovalDto.VATID,
                ExcVAT = createApprovalDto.ExcVAT,
                InVAT = createApprovalDto.InVAT,
                ExpensesID = createApprovalDto.ExpensesID,
                LevelID = createApprovalDto.LevelID,
                ID = createApprovalDto.ID,
                TotalAmount =createApprovalDto.TotalAmount,

            };

            _approvalService.TAdd(approval);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteApproval(int id)
        {
            var value=_approvalService.TGetByID(id);
            _approvalService.TDelete(value);
            return Ok("Bütçe işlemi onaylanmadı.");
        }
        [HttpPut]
        public IApprovalService UpdateApproval(UpdateApprovalDto updateApprovalDto)
        {
            Approval approval = new Approval()
            {
                ApprovalID = updateApprovalDto.ApprovalID,
                CompanyID = updateApprovalDto.CompanyID,
                WorkDoneID = updateApprovalDto.WorkDoneID,
                WorkDoneTypeID = updateApprovalDto.WorkDoneTypeID,
                VATID = updateApprovalDto.VATID,
                ExcVAT = updateApprovalDto.ExcVAT,
                InVAT = updateApprovalDto.InVAT,
                ExpensesID = updateApprovalDto.ExpensesID,
                LevelID = updateApprovalDto.LevelID,
                ID= updateApprovalDto.ID,
                TotalAmount=updateApprovalDto.TotalAmount,
        
            };
            _approvalService.TUpdate(approval);

            return (IApprovalService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetApproval")]

        public IActionResult GetApproval(int id)
        {
           var value= _approvalService.TGetByID(id);
            return Ok(value);

        }
   
    
    }

}
