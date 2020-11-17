using EventImplementation.Models.Communication;

namespace EventImplementation.Models
{
    public delegate void NameChangedEventHandler(object sender, NameChangedEventArgs e);

    public class Dispatcher
    {
        private string name;

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                    OnNameChanged(new NameChangedEventArgs(value));
                name = value;
            }
        }

        public event NameChangedEventHandler NameChanged;

        protected void OnNameChanged(NameChangedEventArgs e)
            => NameChanged?.Invoke(this, e);
    }
}
