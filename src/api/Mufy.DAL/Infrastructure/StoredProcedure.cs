using Mufy.DAL.Infrastructure.Attributes;
using Mufy.DAL.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Mufy.DAL.Infrastructure
{
    internal abstract class StoredProcedure
    {
        public string GetName()
        {
            var nameAttribute = (ProcedureName)GetType().GetCustomAttributes(typeof(ProcedureName)).FirstOrDefault();

            if (nameAttribute == null)
                return GetType().Name;

            return nameAttribute.Name;
        }

        public StoredProcedureParameter[] GetParameters()
        {
            var procedureParameters = GetFieldsWithProcedureParameterAttribute(this);

            var result = procedureParameters
                .Select(f => new StoredProcedureParameter(f.Name, f.GetValue(this), GetParameterDirection(f.CustomAttributes)))
                .ToArray();

            return result;
        }

        public FieldInfo[] GetOutFields()
        {
            var outParameters = Reflector.GetFieldsWithAttribute(this, typeof(OutParameter));
            var inOutParameters = Reflector.GetFieldsWithAttribute(this, typeof(InOutParameter));
            var result = outParameters.Concat(inOutParameters).ToArray();
            return result;
        }

        public FieldInfo GetReturnField()
        {
            var result = Reflector.GetFieldsWithAttribute(this, typeof(ReturnValue));

            if (result.Length > 1)
            {
                throw new MoreThanOneReturnParameterException();
            }

            return result.FirstOrDefault();
        }

        private ParameterDirection GetParameterDirection(IEnumerable<CustomAttributeData> attributes)
        {
            var attribute = attributes
                .Select(a => a.AttributeType)
                .FirstOrDefault();

            return attribute.Name switch
            {
                nameof(InParameter) => ParameterDirection.Input,
                nameof(OutParameter) => ParameterDirection.Output,
                nameof(InOutParameter) => ParameterDirection.InputOutput,
                nameof(ReturnValue) => ParameterDirection.ReturnValue,
                _ => throw new Exception()
            };
        }

        private static FieldInfo[] GetFieldsWithProcedureParameterAttribute(StoredProcedure storedProcedure)
        {
            var result = Reflector.GetFieldsWithAttribute(storedProcedure, typeof(ProcedureParameter));
            return result;
        }
    }
}
