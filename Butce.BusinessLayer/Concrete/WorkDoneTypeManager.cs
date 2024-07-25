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
    public class WorkDoneTypeManager : IWorkDoneTypeService
    {
        private readonly IWorkDoneTypeDal _workDoneTypeDal;

        public WorkDoneTypeManager(IWorkDoneTypeDal workDoneTypeDal)
        {
            _workDoneTypeDal = workDoneTypeDal;
        }

        public void TAdd(WorkDoneType entity)
        {
           _workDoneTypeDal.Add(entity);
        }

        public void TDelete(WorkDoneType entity)
        {
            _workDoneTypeDal.Delete(entity);
        }

        public List<WorkDoneType> TGetAll()
        {
            return _workDoneTypeDal.GetAll();
        }

        public WorkDoneType TGetByID(int id)
        {
            return _workDoneTypeDal.GetByID(id);
        }

        public void TUpdate(WorkDoneType entity)
        {
            _workDoneTypeDal.Update(entity);
        }
    }
}
