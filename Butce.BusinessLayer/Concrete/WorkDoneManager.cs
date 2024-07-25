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
    public class WorkDoneManager : IWorkDoneService
    {
        private readonly IWorkDoneDal _workDoneDal;

        public WorkDoneManager(IWorkDoneDal workDoneDal)
        {
            _workDoneDal = workDoneDal;
        }

        public void TAdd(WorkDone entity)
        {
            _workDoneDal.Add(entity);
        }

        public void TDelete(WorkDone entity)
        {
            _workDoneDal.Delete(entity);
        }

        public List<WorkDone> TGetAll()
        {
            return _workDoneDal.GetAll();
        }

        public WorkDone TGetByID(int id)
        {
            return _workDoneDal.GetByID(id);
        }

        public void TUpdate(WorkDone entity)
        {
            _workDoneDal.Update(entity);
        }
    }
}
