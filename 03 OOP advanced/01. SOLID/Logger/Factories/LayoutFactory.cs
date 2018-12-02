namespace Logger.Factories
{
    using Contracts;
    using Logger.Layouts;
    using System;

    public class LayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            if (type == nameof(SimpleLayout))
            {
                return new SimpleLayout();
            }
            else
            {
                throw new ArgumentException("Invalid layout!");
            }
        }
    }
}
