using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using SecondLab._3D;

namespace SecondLab
{
    public interface IPointCamera
    {
        Basis Basis { get; }

        float ScreenDist { get; }

        int ScreenWidth { get; }

        int ScreenHeight { get; }

        IEnumerable<Polygon2D> GetProjection(IPolyhedron polyhedron, ILighting lighting);
    }
}
