using System.Collections.Generic;
using System.Linq;

namespace Decorator.V2
{
    public class ActualBeverage : BeverageBase
    {
        public ActualBeverage(List<ICondiment> condiments) : base(condiments)
        {
            Description = "Actual with " + CondimentSummary;
        }

        public override float Cost()
        {
            return 2f + Condiments.Sum(condiment => condiment.Cost);
        }
    }
}