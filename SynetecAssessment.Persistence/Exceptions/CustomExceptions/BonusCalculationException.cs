using System;

namespace SynetecAssessmentApi.Persistence.Exceptions.CustomExceptions
{
    public class BonusCalculationException : Exception
    {
        const string exceptionTag = "Calculation Exception";

        public BonusCalculationException() { }
        public BonusCalculationException(string message) :
            base(String.Format("{0} - {1}",
                exceptionTag, message))
        { }
        public BonusCalculationException(string message, Exception innerException)
            : base(String.Format("{0} - {1}", exceptionTag, message), innerException)
        { }

    }
}
