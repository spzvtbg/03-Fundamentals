namespace Logger.Factories
{
    using Logger.Contracts;
    using Logger.Enums;
    using Logger.Errors;
    using System;
    using System.Globalization;

    public class ErrorFactory
    {
        private const string DATE_FORMAT = "M/d/yyyy h:mm:ss tt";

        public IError CreateError(string dateTime, string errorString, string message)
        {
            var date = DateTime.ParseExact(dateTime, DATE_FORMAT, CultureInfo.InvariantCulture);
            var errorLevel = default(ErrorLevel);
            var success = Enum.TryParse(errorString, true, out errorLevel);

            if (!success)
            {
                throw new ArgumentException("Invalid error level in the error factory.");
            }

            return new Error(date, errorLevel, message);
        }
    }
}
