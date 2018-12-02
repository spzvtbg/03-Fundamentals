namespace Logger.Layouts
{
    using Contracts;
    
    using System.Globalization;

    public class SimpleLayout : ILayout
    {
        private const string DATE_FORMAT = "M/d/yyyy h:mm:ss tt";
        private const string LAYOUT_FORMAT = "{0} - {1} - {2}";

        public string Format(IError error)
        {
            return string
                .Format(LAYOUT_FORMAT
                , error.Time.ToString(DATE_FORMAT
                , CultureInfo.InvariantCulture)
                , error.ErrorLevel
                , error.Message);
        }
    }
}
