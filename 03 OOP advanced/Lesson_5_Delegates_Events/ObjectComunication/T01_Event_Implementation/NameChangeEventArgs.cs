namespace T01_Event_Implementation
{
    using System;

    public class NameChangeEventArgs : EventArgs
    {
        public string Name { get; private set; }
    }
}
