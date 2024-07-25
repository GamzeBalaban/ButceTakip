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
    public class VATManager : IVATService
    {
        private readonly IVATDal _vatDal;

        public VATManager(IVATDal vatDal)
        {
            _vatDal = vatDal;
        }

        public void TAdd(VAT entity)
        {
            _vatDal.Add(entity);
        }

        public void TDelete(VAT entity)
        {
            _vatDal.Delete(entity);
        }

        public List<VAT> TGetAll()
        {
            return _vatDal.GetAll();
        }

        public VAT TGetByID(int id)
        {
            return _vatDal.GetByID(id);
        }

        public void TUpdate(VAT entity)
        {
            _vatDal.Update(entity);
        }
    }
}
