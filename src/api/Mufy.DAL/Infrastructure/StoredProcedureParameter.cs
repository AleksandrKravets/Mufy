using System.Data;

namespace Mufy.DAL.Infrastructure
{
    internal class StoredProcedureParameter
    {
        public string Name { get; private set; }
        public object Value { get; private set; }
        public ParameterDirection Direction { get; private set; }

        public StoredProcedureParameter(string parameterName, object parameterValue, ParameterDirection parameterDirection)
        {
            Name = parameterName;
            Value = parameterValue;
            Direction = parameterDirection;
        }
    }
}
