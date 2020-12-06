using InfernoInfinity.Contracts;

namespace InfernoInfinity.Commands
{
    public class RemoveCommand : Command
    {
        private IWeaponRepository repository;

        public RemoveCommand(string[] arguments) : base(arguments)
        {
        }

        public override string Execute()
        {
            string weaponName = Arguments[1];
            int socketIndex = int.Parse(Arguments[2]);

            var weapon = repository.Get(weaponName);
            weapon.RemoveGem(socketIndex);
            return string.Empty;
        }
    }
}
