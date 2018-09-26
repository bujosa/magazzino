using System;
using System.Collections.Generic;
using Magazzino.Data;
using Magazzino.Models.Infraestruture;
using Magazzino.Repository.Framework;
using System.Linq;
using Magazzino.Helpers.Infraestructure;
using Magazzino.Helpers.Utils;
using AutoMapper;

namespace  Magazzino.Service.Base
{
    public class BaseService<Vm, Ent> : IBaseService<Vm> where Ent : BaseEntity where Vm : BaseViewModel
    {
        protected IRepository<Ent> Repository;

        public BaseService(IRepository<Ent> repository)
        {
            this.Repository = repository;
        }

        public ServiceResult Delete(Vm viewModel)
        {
            ServiceResult serviceResult = new ServiceResult();

            var ToDelete = ((List<Ent>)(this.Repository.GetAll(i => i.RowId == viewModel.RowId).Data)).FirstOrDefault();

            if(ToDelete == null)
            {
                serviceResult.Success = false;
                serviceResult.ResultTitle = "ERROR: Record No Found";
                serviceResult.Messages.Add(Error.GetErrorMessage(Error.RecordNotFound));

                return serviceResult;
            }

            var result = Repository.Delete(ToDelete).Data;

            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.ResultObject = MapperHelper.Instance.Map<Ent, Vm>(result);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));

            return serviceResult;
        }

        public ServiceResult GetAll()
        {
            ServiceResult serviceResult = new ServiceResult();

            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));

            serviceResult.ResultObject = 
                MapperHelper.Instance.Map<List<Ent>, List<Vm>>
            (this.Repository.GetAll().Data);

            return serviceResult;
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult serviceResult = new ServiceResult();

            var result = ((List<Ent>)this.Repository.
                          GetAll(x => x.Id == id).Data)
                .FirstOrDefault();

            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));
            serviceResult.ResultObject = MapperHelper.Instance.Map<Ent, Vm>(result);

            return serviceResult;
        }

        public ServiceResult GetByRowId(string rowId)
        {
            ServiceResult serviceResult = new ServiceResult();

            var result = ((List<Ent>)this.Repository.
                          GetAll(x => x.RowId == rowId).Data)
                .FirstOrDefault();

            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));
            serviceResult.ResultObject = MapperHelper.Instance.Map<Ent, Vm>(result);

            return serviceResult;
        }

        public ServiceResult Insert(Vm viewModel)
        {
            ServiceResult serviceResult = new ServiceResult();

            var Entity = MapperHelper.Instance.Map<Vm, Ent>(viewModel);
            Entity.RowId = Guid.NewGuid().ToString();

            var result = this.Repository.Insert(Entity);

            serviceResult.Success = result.Successfull;
            serviceResult.ResultTitle = (result.Successfull ? Error.GetErrorMessage(Error.CorrectTransaction) : Error.GetErrorMessage(Error.InternalServerError));
            serviceResult.Messages.Add(result.Successfull ? "Inserted" : "Failed");
            serviceResult.ResultObject = MapperHelper.Instance.Map<Ent, Vm>(result.Data);

            return serviceResult;
        }

        public ServiceResult Update(Vm viewModel)
        {
            ServiceResult serviceResult = new ServiceResult();

            var ToUpdate = this.Repository.GetById((int)viewModel.Id).Data;

            if(ToUpdate == null)
            {
                serviceResult.Success = false;
                serviceResult.ResultTitle = "ERROR: Record No Found";
                serviceResult.Messages.Add(Error.GetErrorMessage(Error.RecordNotFound));

                return serviceResult;
            }

            var Entity = MapperHelper.Instance.Map<Vm, Ent>(viewModel);

            var result = this.Repository.Update(Entity);

            serviceResult.Success = result.Successfull;
            serviceResult.ResultTitle = (result.Successfull ? Error.GetErrorMessage(Error.CorrectTransaction) : Error.GetErrorMessage(Error.InternalServerError));
            serviceResult.Messages.Add(result.Successfull ? "Updated" : "Failed");
            serviceResult.ResultObject = MapperHelper.
                Instance.Map<Ent, Vm>(result.Data);

            return serviceResult;
        }
    }
}
