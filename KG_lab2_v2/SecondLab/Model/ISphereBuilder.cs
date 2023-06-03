using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public interface ISphereBuilder
    {
        Sphere Build();
        Sphere Build(int angle);
    }
}
