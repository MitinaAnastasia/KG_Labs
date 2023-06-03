using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public interface ILighting
    {
        float GetLevel(Polygon3D polygon);
    }
}
