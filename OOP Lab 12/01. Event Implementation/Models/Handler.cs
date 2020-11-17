using EventImplementation.Models.Communication;
using System;

namespace EventImplementation.Models
{
    public class Handler
    {
        public void OnDispatcherNameChanged(object sender, NameChangedEventArgs e)
            => Console.WriteLine($"Dispatcher's name changed to {e.Name}.");
    }
}
