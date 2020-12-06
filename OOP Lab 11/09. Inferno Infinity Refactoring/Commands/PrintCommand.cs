using InfernoInfinity.Contracts.Narrow;
using InfernoInfinity.Helpers;

namespace InfernoInfinity.Commands
{
    public class PrintCommand : Command
    {
        private IWeaponRepository repository;

        public PrintCommand(string[] arguments) : base(arguments)
        {
            Injector.Instance.PerformInjection(this);
        }

        public override string Execute()
        {
            string weaponName = Arguments[1];
            var weapon = repository.Get(weaponName);
            return weapon.ToString();
        }
    }
}
