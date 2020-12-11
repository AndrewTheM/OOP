using MilitaryElite.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Linq;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        private string codeName;
        private MissionState state;

        public string CodeName
        {
            get => codeName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Code name cannot be empty.");
                codeName = value;
            }
        }

        public string State
        {
            get => state.ToString();
            private set
            {
                if (!Enum.GetNames(typeof(MissionState)).Contains(value))
                    throw new ArgumentException("Invalid state.");
                state = Enum.Parse<MissionState>(value);
            }
        }

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public void Complete() => state = MissionState.finished;

        public override string ToString()
            => $"Code Name: {CodeName} State: {State}";
    }
}
