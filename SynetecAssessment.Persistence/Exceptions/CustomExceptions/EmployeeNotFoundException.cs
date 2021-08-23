using System;

namespace SynetecAssessmentApi.Persistence.Exceptions.CustomExceptions
{
    public class EmployeeNotFoundException : Exception
    {
        const string exceptionTag =
            "Employee not found";

        public EmployeeNotFoundException() { }
        public EmployeeNotFoundException(string message) :
            base(String.Format("{0} - {1}",
                exceptionTag, message))
        { }
        public EmployeeNotFoundException(string message, Exception innerException)
            : base(String.Format("{0} - {1}", exceptionTag, message), innerException)
        { }
    }
}
