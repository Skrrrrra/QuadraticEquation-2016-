using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2016\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2016\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера
            int a =3;
            
            //запись в строку содержимого 2 строки файла
            string secondLine;
            using (var reader = new StreamReader(inputpath))
            {
                secondLine = reader.ReadLine();  // записываем в переменную
            }
            //запись из строки в массив строк с разделением
            string[] secondlineforint = secondLine.Split(' ');

            //массив для действий над числами
            int[] lastintarr;
            lastintarr = new int[a];

            //запись в интовый массив из массива строк
            int count = 0;
            foreach (var s in secondlineforint)
            {
                lastintarr[count] = Convert.ToInt32(s);
                count++;
            }
            #endregion

            int A = lastintarr[0];
            int B = lastintarr[1];
            int C = lastintarr[2];

            string coeferror = "Ur coef's is wrong.Check and  fix it";
            //проверка на соответствие условия квадратному уравнению
            #region
            if (A == 0 && B == 0 && C == 0)
            {
                File.WriteAllBytes(outputpath, Encoding.UTF8.GetBytes(coeferror));
            }
            else if (A == 0 && B == 1 && C == 0)
            {
                File.WriteAllBytes(outputpath, Encoding.UTF8.GetBytes(coeferror));
            }
            else if (A == 0 && B == 0 && C == 1)
            {
                File.WriteAllBytes(outputpath, Encoding.UTF8.GetBytes(coeferror));
            }
            #endregion
            else
            {
                double d = (Math.Pow(B, 2)) - 4 * A * C;

                if (d >= 0)
                {
                    double x1 = ((-B + Math.Sqrt(d)) / (2 * a));
                    double x2 = ((-B - Math.Sqrt(d)) / (2 * a));

                    if (x1 > 0 | x2>0)
                    {
                        File.WriteAllText(outputpath, 1.ToString());
                    }
                    else
                    {
                        File.WriteAllText(outputpath, 2.ToString());
                    }
                }
                else if (d < 0)
                {
                    File.WriteAllText(outputpath, 0.ToString());

                }
            }
        }
    }
}