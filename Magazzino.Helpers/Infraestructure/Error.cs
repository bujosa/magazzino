using System;
using System.Collections.Generic;
using System.Text;
using Magazzino.Helpers.Extensions;
using System.Linq;

namespace Magazzino.Helpers.Infraestructure
{
    public static class Error
    {
        static Dictionary<int, string> Errores;

        #region  ErrorListDeclaration
        public const int CorrectTransaction = 0;
        public const int EmptyModel = 1;
        public const int InvalidUser = 2;
        public const int RecordNotFound = 3;
        public const int InternalServerError = 4;
        public const int UnexpectedError = 5;
        public const int NotAuthorized = 6;
        #endregion

        static Error()
        {
            Errores = new Dictionary<int, string>();
            if(Errores.Count > 0)
            {
                return;
            }

            foreach (var field in typeof(Error).GetFields())
            {
                Errores.Add((int)field.GetValue(null), field.Name.ToString().SplitCammeCase());
            }
        }

        public static string GetErrorMessage(int error)
        {
            return Errores.SingleOrDefault(e => e.Key == error).Value;
        }
    }
}