using InfernoInfinity.Contracts.Narrow;
using InfernoInfinity.Helpers;

namespace InfernoInfinity.Commands
{
    public class RemoveCommand : Command
    {
        private IWeaponRepository repository;

        public RemoveCommand(string[] arguments) : base(arguments)
        {
            Injector.Instance.PerformInjection(this);
        }

        public override string Execute()
        {
            string weaponName = Arguments[1];
            int socketIndex = int.Parse(Arguments[2]);

            var weapon = repository.Get(weaponName);
            weapon.RemoveGem(socketIndex);
            return base.Execute();
        }
    }
}
