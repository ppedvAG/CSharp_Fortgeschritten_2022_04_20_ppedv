using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternAbstract
{
	internal class HamAndCheese : SandwichBuildable
    {
        public HamAndCheese()
        {
            sandwich = new Sandwich(SandwichType.HamAndCheese);
        }

        public override void AddBread()
        {
            sandwich["bread"] = "White";
        }

        public override void AddMeat()
        {
            sandwich["meat"] = "Ham";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "American";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "None";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }
    }
}
