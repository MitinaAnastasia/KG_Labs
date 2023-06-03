using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public class SphereBuilder : ISphereBuilder
    {
        private readonly int partitionCount;

        public int angle { get; }

        private int[] indices;

        public SphereBuilder(int partitionCount)
        {
            this.partitionCount = partitionCount;
        }


        public Sphere Build()
        {
            //List<PointH3D> basePoints = CreateBasePoints();
            float[] basePoints = VertexDeclaration();
            List<Polygon3D> result = new List<Polygon3D>();
            AddSidePolygons(result, basePoints);
            //AddBasePolygons(result, basePoints);
            return new Sphere(result);
        }

        public Sphere Build(int angle)
        {
            //List<PointH3D> basePoints = CreateBasePoints();
            float[] basePoints = VertexDeclaration();
            List<Polygon3D> result = new List<Polygon3D>();
            AddSidePolygons(result, basePoints, angle);
            //AddBasePolygons(result, basePoints);
            return new Sphere(result);
        }

        private void AddSidePolygons(List<Polygon3D> result, float[] basePoints)
        {
            List<PointH3D> points = new List<PointH3D>();
            for (int i = 2; i < basePoints.Length; i = i + 3)
            {
                PointH3D point = new PointH3D(basePoints[i - 2], basePoints[i - 1], basePoints[i]);
                points.Add(point);
            }
            for (int i = 2; i < points.Count; i = i + 3)
            {
                Polygon3D polygon = new Polygon3D(points[i - 2], points[i - 1], points[i]);
                if (polygon.points.ElementAt(0).Y >= 0 && polygon.points.ElementAt(1).Y >= 0 && polygon.points.ElementAt(2).Y >= 0)
                {
                        result.Add(polygon);
                }
            }
        }

        private void AddSidePolygons(List<Polygon3D> result, float[] basePoints, int angle)
        {
            List<PointH3D> points = new List<PointH3D>();
            for (int i = 2; i < basePoints.Length; i = i + 3)
            {
                PointH3D point = new PointH3D(basePoints[i - 2], basePoints[i - 1], basePoints[i]);
                points.Add(point);
            }
            for (int i = 2; i < points.Count; i = i + 3)
            {
                Polygon3D polygon = new Polygon3D(points[i - 2], points[i - 1], points[i]);
                if (polygon.points.ElementAt(0).Y >= 0 && polygon.points.ElementAt(1).Y >= 0 && polygon.points.ElementAt(2).Y >= 0)
                {
                    if (polygon.points.ElementAt(0).X >= Math.Cos(angle * Math.PI / 180) && polygon.points.ElementAt(1).X >= Math.Cos(angle * Math.PI / 180) && polygon.points.ElementAt(2).X >= Math.Cos(angle * Math.PI / 180))
                        result.Add(polygon);
                }
            }
        }

        private void AddBasePolygons(List<Polygon3D> result, float[] basePoints)
        {
                List<PointH3D> points = new List<PointH3D>();
                for (int i = 2; i < basePoints.Length; i = i + 3)
                {
                    PointH3D point = new PointH3D(basePoints[i - 2], basePoints[i - 1], basePoints[i]);
                    points.Add(point);
                }
                PointH3D zeroPoint = new PointH3D(0, 0, 0);
                List<PointH3D> nextPoint = new List<PointH3D>();
                for (int i = 0; i < points.Count; i++)
                {
                    if (points[i].Y == 0)
                    {
                        nextPoint.Add(points[i]);
                    }
                }
            for (int i = 1; i < nextPoint.Count; i = i + 1)
                {
                    Polygon3D polygon = new Polygon3D(zeroPoint, nextPoint[i - 1], nextPoint[i]);
                    result.Add(polygon);
                }
                Polygon3D polygonend = new Polygon3D(zeroPoint, nextPoint[nextPoint.Count - 1], nextPoint[0]);
                result.Add(polygonend);
        }

            public float[] VertexDeclaration()
        {
            //Задаем вершины сегмента сферы в сф коорд
            var vert_sph_l = new List<float>
            {
                1,  (float)Math.PI*2/3, 0,
                1, (float)Math.PI*2/3, (float)Math.PI*2/5,
                1, (float)Math.PI/3, (float)Math.PI/5,
            };

            var indices_l = new List<int>
            {
                 0, 1, 2
            };
            //Достроим сферу из грани икосаедра
            Build_sphere(vert_sph_l, indices_l);

            //Дробление
            int crushing_degree = 7;
            for (int i = 0; i < crushing_degree; i++)
                Crushing(vert_sph_l, indices_l);


            /**/
            //Преобразование листа в массив
            float[] vert_sph = vert_sph_l.ToArray();
            indices = indices_l.ToArray();

            //Преобразование координат 
            float[] vert_cart = Spherical_to_cartesian(vert_sph);

            return vert_cart;
        }

        void Build_sphere(List<float> v_l, List<int> ind_l)
        {
            /*
             * v_l - список вершин одной грани икосаедра
             * ind_l - буфер вершин для одной грани икосаедра
             * 
             * Метод копирует вершины 19 раз, поворачивает относительно центра координат,
             * достраивая сферу по сегменту, переданному в метод
             * 
             * В буфер вершин заносятся новые вешины 
             */
            int vertex_count = v_l.Count / 3;
            //1 - треугольник нижнего основания
            for (int i = 0; i < vertex_count; i++) //i - номер вершины
            {
                v_l.Add(v_l[3 * i]);//r
                //float tetta = ((float)Math.PI - v_l[3 * i + 1] + ((float)Math.PI) / 3);
                float tetta = ((float)Math.PI - v_l[3 * i + 1] + ((float)Math.PI) / 3);
                v_l.Add(tetta);//tetta
                v_l.Add(v_l[3 * i + 2]);//phi

            }
            //Пополнение буфера индексов
            int buffer_count = ind_l.Count;
            for (int i = 0; i < buffer_count; i++)
            {
                ind_l.Add(ind_l[i] + vertex_count);
                if ((i + 1) % 3 == 0)
                {
                    //При отражении треугольники выворачиваются, поэтому меняем местами две вершины для корректного отображения
                    int temp = ind_l[ind_l.Count - 2];
                    ind_l[ind_l.Count - 2] = ind_l[ind_l.Count - 1];
                    ind_l[ind_l.Count - 1] = temp;
                }
            }

            // 2 - Построение нижней половины икосаедра
            vertex_count = v_l.Count / 3;
            for (int i = 1; i < 5; i++)// 4 раза поворачиваем копии двух (разбитых) треугольников - получаем половину икосааедра
            {
                for (int j = 0; j < vertex_count; j++)// j - номер вершины сегменте из 2 треуг
                {
                    v_l.Add(v_l[3 * j]);//r
                    v_l.Add(v_l[3 * j + 1]);//tetta
                    v_l.Add(v_l[3 * j + 2] + i * (float)Math.PI * 2 / 5);//phi
                }
            }
            //Пополнение буфера индексов
            buffer_count = ind_l.Count;
            for (int i = buffer_count; i < buffer_count * 5; i++) ind_l.Add(ind_l[i - buffer_count] + vertex_count);

            // 3 - Построение второй половины икосаедра
            vertex_count = v_l.Count / 3;

            for (int j = 0; j < vertex_count; j++)// j - номер вершины в нижней половинке 
            {
                v_l.Add(v_l[3 * j]);//r
                v_l.Add((float)Math.PI - v_l[3 * j + 1]);//tetta
                v_l.Add(v_l[3 * j + 2] + (float)Math.PI / 5);//phi
            }
            buffer_count = ind_l.Count;
            for (int i = 0; i < buffer_count; i++)
            {
                ind_l.Add(ind_l[i] + vertex_count);
                if ((i + 1) % 3 == 0)
                {
                    //При отражении треугольники выворачиваются, поэтому меняем местами две вершины для корректного отображения
                    int temp = ind_l[ind_l.Count - 2];
                    ind_l[ind_l.Count - 2] = ind_l[ind_l.Count - 1];
                    ind_l[ind_l.Count - 1] = temp;
                }
            }
        }

        void Crushing(List<float> v_l, List<int> ind_l)
        {

            int current_buffer_ind = 0;// проходим по буферу

            int triangle_count = ind_l.Count / 3; //количество треугольников для разбиения
            for (int i = 0; i < triangle_count; i++) //i - номер тройки вершин - номер треугольника, который дробим
            {
                //Записываем текущий треугольник
                int[] cutted_buf = new int[3];
                for (int j = 0; j < 3; j++) cutted_buf[j] = ind_l[i * 3 + j];

                float[] vert_of_cutted_buf = new float[9];
                for (int j = 0; j < 3; j++)//вершина
                    for (int k = 0; k < 3; k++)//координата
                        vert_of_cutted_buf[3 * j + k] = v_l[cutted_buf[j] * 3 + k];

                //Ищем центры отрезков
                float[] centers = new float[9];
                centers = Midpoints_triangle(vert_of_cutted_buf);

                //Подправим центры вертикальных отрезков

                //Добавляем центры в  общий лист с вершинами v_l
                int max_vert = v_l.Count / 3;
                for (int j = 0; j < 9; j++) v_l.Add(centers[j]);

                //Заменяем тройку индексов в буфере на индексы маленького центрального треугольника
                //int temp = max_vert - cutted_buf[0];
                for (int j = 0; j < 3; j++) ind_l[current_buffer_ind + j] = max_vert + j;

                //Добавляем в буфер индексов три пары для крайних треугольников
                for (int j = 0; j < 3; j++)// для каждого из треугольников
                {
                    ind_l.Add(max_vert + j);
                    ind_l.Add(cutted_buf[(j + 1) % 3]);
                    ind_l.Add(max_vert + (j + 1) % 3);

                }

                current_buffer_ind += 3;
            }
        }

        float[] Midpoints_triangle(float[] vert)
        {
            float[] res = new float[9];
            for (int i = 0; i < 3; i++)
            {
                /* i - пара вершин
                 *  vert[ 3*i + 0/1/2] - первая вершина тройки r/tetta/phi
                 *  vert[ (3*(i+1) + 0/1/2))%9] - вторая вершина тройки r/tetta/phi
                 */

                //считаем r
                res[3 * i] = (vert[3 * i] + vert[(3 * (i + 1)) % 9]) / 2;
                //считаем tetta
                res[3 * i + 1] = (vert[3 * i + 1] + vert[(3 * (i + 1) + 1) % 9]) / 2;
                //считаем phi
                //Если в треугольнике есть "высшая" или "низшая" точка сферы 
                if (vert[3 * i + 1] == 0 | vert[3 * i + 1] == (float)Math.PI) res[3 * i + 2] = vert[(3 * (i + 1) + 2) % 9];
                else if (vert[(3 * (i + 1) + 1) % 9] == 0 | vert[(3 * (i + 1) + 1) % 9] == (float)Math.PI) res[3 * i + 2] = vert[3 * i + 2];
                else res[3 * i + 2] = (vert[3 * i + 2] + vert[(3 * (i + 1) + 2) % 9]) / 2;


            }
            return res;
        }
        float[] Spherical_to_cartesian(float[] arr)
        {
            /*
             * arr - массив координат вершин, которые нужно перевести в декартовы координаты
             * x y z - декартовы координаты
             * arr[3i] - координата r сферической системы
             * arr[3i+1] - координата tetta сферической системы
             * arr[3i+2] - координата phi сферической системы
             * xyz записываются поверх r, tetta и phi
             */
            for (int i = 0; i < arr.Length; i = i + 3)
            {
                float x = (float)(arr[i] * Math.Sin(arr[i + 1]) * Math.Cos(arr[i + 2]));
                float y = (float)(arr[i] * Math.Sin(arr[i + 1]) * Math.Sin(arr[i + 2]));
                float z = (float)(arr[i] * Math.Cos(arr[i + 1]));
                arr[i] = x;
                arr[i + 1] = y;
                arr[i + 2] = z;
            }
            return arr;
        }



    }
}
