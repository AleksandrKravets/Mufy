using System;
using System.Linq;

namespace Mufy.Common.Helpers
{
    public static class ParametersHelper
    {
        public static void ThrowIfAnyNull(params object[] parameters)
        {
            var param = parameters.FirstOrDefault(x => x == null);

            if (param != null)
                throw new ArgumentNullException(param.GetType().Name);
        }
    }
}
