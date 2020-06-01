using System;

namespace Mufy.DAL.Infrastructure.Exceptions
{
    internal class MoreThanOneReturnParameterException : Exception
    {
        public MoreThanOneReturnParameterException(string message) : base(message)
        {
        }

        public MoreThanOneReturnParameterException() : base("There is more than one return value in the procedure.")
        {
        }
    }
}
