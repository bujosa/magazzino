using System;
using Magazzino.Models.Infraestruture;

namespace Magazzino.Service.Base
{
    public interface IBaseService<T>
    {
        ServiceResult Insert(T viewModel);
        ServiceResult Update(T viewModel);
        ServiceResult Delete(T viewModel);
        ServiceResult GetAll();
        ServiceResult GetById(int id);
        ServiceResult GetByRowId(string rowId);
    }
}
