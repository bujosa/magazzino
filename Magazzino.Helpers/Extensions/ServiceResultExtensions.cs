using System;
using System.Collections.Generic;
using System.Text;
using Magazzino.Helpers.Infraestructure;
using Magazzino.Models.Infraestruture;

namespace Magazzino.Helpers.Extensions
{
    public static class ServiceResultExtensions
    {
        public static ServiceResult LogError(this ServiceResult sr, Exception ex)
        {
            sr.Success = false;
            sr.ResultObject = Error.GetErrorMessage(Error.UnexpectedError);
            sr.Messages.Add(ex.Message);
            return sr;

        }
    }
}
