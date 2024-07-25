using Butce.BusinessLayer.Abstract;
using Butce.DataAccessLayer.Abstract;
using Butce.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.BusinessLayer.Concrete
{
    public class ApprovalManager : IApprovalService
    {

        private readonly IApprovalDal _approvalDal;

        public ApprovalManager(IApprovalDal approvalDal)
        {
            _approvalDal = approvalDal;
        }

        public void TAdd(Approval entity)
        {
            _approvalDal.Add(entity);
        }

        public void TDelete(Approval entity)
        {
            _approvalDal.Delete(entity);
        }

        public List<Approval> TGetAll()
        {
            return _approvalDal.GetAll();
        }

        public Approval TGetByID(int id)
        {
            return _approvalDal.GetByID(id);
        }

        public object TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Approval entity)
        {
            _approvalDal.Update(entity);
        }
    }
}
