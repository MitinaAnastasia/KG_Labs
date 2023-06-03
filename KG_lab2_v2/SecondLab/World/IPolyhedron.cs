using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public interface IPolyhedron 
    {
        IEnumerable<Polygon3D> Polygons { get; }

        IPolyhedron Transform(TransformationH3D transformation);

    }
}
