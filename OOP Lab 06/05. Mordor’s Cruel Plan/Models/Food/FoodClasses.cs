namespace MordorsCruelPlan.Models.Food
{
    public class Cram : Food
    {
        public Cram() : base(2)
        {
        }
    }

    public class Lembas : Food
    {
        public Lembas() : base(3)
        {
        }
    }

    public class Apple : Food
    {
        public Apple() : base(1)
        {
        }
    }

    public class Melon : Food
    {
        public Melon() : base(1)
        {
        }
    }

    public class HoneyCake : Food
    {
        public HoneyCake() : base(5)
        {
        }
    }

    public class Mushrooms : Food
    {
        public Mushrooms() : base(-10)
        {
        }
    }

    public class UnknownFood: Food
    {
        public UnknownFood() : base(-1)
        {
        }
    }
}