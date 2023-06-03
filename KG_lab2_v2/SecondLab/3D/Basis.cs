using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SecondLab._3D
{
    public class Basis
    {
        //Компонента Center, представляющая собой точку центра
        public Vector3 Center { get; private set; }

        public Polygon3D Poilygon { get; private set; }

        // Конструктор класса Basis. Присваивает параметры всем полям класса
        public Basis(Basis value) { Center = value.Center; Poilygon = value.Poilygon; }
        // Конструктор класса Basis. Присваивает параметры Center, XAxis, YAxis, ZAxis полям класса
        public Basis(Vector3 center, Polygon3D poily) { Center = center; Poilygon = poily; }

        public static Basis BaseBasis(Vector3 center) => new Basis(center, new Polygon3D(new PointH3D(1, 0, 0), new PointH3D(0, 1, 0), new PointH3D(0, 0, 1)));

        //Матрица перевода в локальные координаты
        public Matrix4x4 LocalCoordsMatrix => new Matrix4x4
            (
                Poilygon.points[0].X, Poilygon.points[1].X, Poilygon.points[2].X, 0,
                Poilygon.points[0].Y, Poilygon.points[1].Y, Poilygon.points[2].Y, 0,
                Poilygon.points[0].Z, Poilygon.points[1].Z, Poilygon.points[2].Z, 0,
                0, 0, 0, 1
            );

        //Матрица перевода в глобальные координаты
        public Matrix4x4 GlobalCoordsMatrix => new Matrix4x4
           (
               Poilygon.points[0].X, Poilygon.points[0].Y, Poilygon.points[0].Z, 0,
               Poilygon.points[1].X, Poilygon.points[1].Y, Poilygon.points[1].Z, 0,
               Poilygon.points[2].X, Poilygon.points[2].Y, Poilygon.points[2].Z, 0,
               0, 0, 0, 1
           );

        public Vector3 ToLocalCoords(Vector3 global)
        {
            //Находим позицию вектора относительно точки центра и раскладываем в локальном базисе
            return Vector3.Transform(global - Center, LocalCoordsMatrix);
        }
        public Vector3 ToGlobalCoords(Vector3 local)
        {
            //В точности да наоборот - раскладываем локальный вектор в глобальном базисе и находим позицию относительно глобального центра
            return Vector3.Transform(local, GlobalCoordsMatrix) + Center;
        }

        public void Move(Vector3 v)
        {
            Center += v;
        }

    }
}
