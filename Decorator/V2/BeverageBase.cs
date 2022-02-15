using System.Collections.Generic;
using System.Linq;

namespace Decorator.V2
{
    public abstract class BeverageBase
    {
        protected readonly List<ICondiment> Condiments;
        protected readonly string CondimentSummary;

        protected BeverageBase(List<ICondiment> condiments)
        {
            Condiments = condiments;
            var condimentDescriptions = Condiments.Select(c => c.Description).ToList();
            CondimentSummary = string.Join(", ", condimentDescriptions);
        }

        public string Description { get; set; } = "Unknow Beverage";

        public abstract float Cost();
    }
}