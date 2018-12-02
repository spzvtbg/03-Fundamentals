namespace T01_Event_Implementation
{
    public delegate NameChangeEventHandler NameChangeEventHandler();

    public class Dispatcher
    {
        public string Name { get; private set; }

        public void OnNameChanged(NameChangeEventArgs args)
        {

        }
    }
}
