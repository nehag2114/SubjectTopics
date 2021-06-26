using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WimeraSampleProject.Resources
{
    public class SubjectsCollection
    {
        public static Dictionary<string, List<string>> subjectCollection = new Dictionary<string, List<string>>
        {
            {"Maths", new List<string>{"Algebra", "Trignometry", "Calculus", "Geometry" } },
            {"Physics", new List<string>{"Optics", "Mechanics", "Kinemetics" } },
            {"Chemistry", new List<string>{"Organic", "Inorganic", "Atomic Structure", "Chemical Bonding", "Periodic Table", "Thermo Chemistry" } },
        };
    }
}
