using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolVeFethet
{
    class Program
    {

		public static double[] mergeSort(double[] arr)
		{
			if (arr.Length <= 1)
			{ //Dizinin boyutu 1 veya daha küçükse
				return arr;
			}
			else
			{
				int middle = (int)(arr.Length / 2);
				double[] left = new double[middle];
				double[] right = new double[arr.Length - middle];
				for (int i = 0; i < middle; i++)
				{   //orta elemanın solunda kalanları left dizisine atarız
					left[i] = arr[i];
				}
				for (int i = middle; i < arr.Length; i++)
				{ //ortadan büyük olanları right dizisine atadık
					right[i - middle] = arr[i];
				}
				left = mergeSort(left);
				right = mergeSort(right);
				double[] result = merge(left, right);
				return result;
			}
		}
		public static double[] merge(double[] left, double[] right)
		{
			double[] result = new double[left.Length + right.Length]; //sıralanmış halini tutacağı için 
			int i = 0, posLeft = 0, posRight = 0;
			while (left.Length > posLeft && right.Length > posRight)
			{
				if (left[posLeft] <= right[posRight])
				{
					result[i] = left[posLeft];

					posLeft++;
				}
				else
				{
					result[i] = right[posRight];
					posRight++;
				}
				i++;
			}
			if (left.Length > posLeft)
			{
				for (; posLeft < left.Length; posLeft++)
				{
					result[i] = left[posLeft];
					i++;
				}
			}
			if (right.Length > posRight)
			{
				for (; posRight < right.Length; posRight++)
				{
					result[i] = right[posRight];
					i++;
				}
			}
			return result;
		}
		static void Main(string[] args)
        {
			String[] tarih = new string[] {"01-08-2020","02-08-2020","03-08-2020 ","04-08-2020","05-08-2020","06-08-2020","07-08-2020","08-08-2020","09-08-2020"
					,"10-08-2020","11-08-2020","12-08-2020","13-08-2020","14-08-2020","15-08-2020","16-08-2020","17-08-2020","18-08-2020","19-08-2020","20-08-2020"
					,"21-08-2020","22-08-2020","23-08-2020","24-08-2020","25-08-2020","26-08-2020","27-08-2020","28-08-2020","29-08-2020","30-08-2020","31-08-2020"
					,"01-09-2020","02-09-2020","03-09-2020","04-09-2020","05-09-2020","06-09-2020","07-09-2020","08-09-2020","09-09-2020","10-09-2020","11-09-2020"
					,"12-09-2020","13-09-2020","14-09-2020","15-09-2020","16-09-2020","17-09-2020","18-09-2020","19-09-2020","20-09-2020","21-09-2020","22-09-2020"
					,"23-09-2020","24-09-2020","25-09-2020","26-09-2020","27-09-2020","28-09-2020","29-09-2020","30-09-2020","01-10-2020","02-10-2020","03-10-2020"
					,"04-10-2020","05-10-2020","06-10-2020","07-10-2020","08-10-2020","09-10-2020","10-10-2020","11-10-2020","12-10-2020","13-10-2020","14-10-2020"
					,"15-10-2020","16-10-2020","17-10-2020","18-10-2020","19-10-2020","20-10-2020","21-10-2020","22-10-2020","23-10-2020","24-10-2020","25-10-2020"
					,"26-10-2020","27-10-2020","28-10-2020","29-10-2020","30-10-2020","31-10-2020","01-11-2020","02-11-2020","03-11-2020","04-11-2020","05-11-2020"
					,"06-11-2020","07-11-2020","08-11-2020","09-11-2020","10-11-2020","11-11-2020","12-11-2020","13-11-2020","14-11-2020","15-11-2020","16-11-2020"
					,"17-11-2020","18-11-2020","19-11-2020","20-11-2020","21-11-2020","22-11-2020","23-11-2020","24-11-2020"};
			double[] kur =new double[] {6.98,6.97,6.99,6.94,6.93,6.99,7.16,7.14,7.02,7.27,7.30,7.25,7.29,7.31,7.27,7.30,7.34,7.37,7.37,7.35,7.30,7.21,7.25,7.22,7.34,7.37,7.35,
							7.32,7.28,7.30,7.31,7.33,7.34,7.36,7.40,7.40,7.41,7.41,7.43,7.45,7.47,7.46,7.46,7.46,7.44,7.47,7.47,7.47,7.52,7.52,7.52,7.53,7.57,7.63,
							7.66,7.66,7.60,7.58,7.55,7.75,7.81,7.75,7.69,7.71,7.70,7.73,7.73,7.75,7.83,7.89,7.89,7.89,7.91,7.87,7.88,7.92,7.91,7.92,7.93,7.91,7.88,
							7.88,7.82,7.80,7.80,7.90,7.94,8.03,8.12,8.10,8.12,8.12,8.12,8.31,8.38,8.45,8.46,8.44,8.44,8.44,8.47,8.18,8.24,8.05,7.79,7.79,7.79,7.63, 7.68,
							7.74,7.72,7.67,7.67,7.67,7.58,7.76};

			double[] kurDizi = {6.98,6.97,6.99,6.94,6.93,6.99,7.16,7.14,7.02,7.27,7.30,7.25,7.29,7.31,7.27,7.30,7.34,7.37,7.37,7.35,7.30,7.21,7.25,7.22,7.34,7.37,7.35,
							7.32,7.28,7.30,7.31,7.33,7.34,7.36,7.40,7.40,7.41,7.41,7.43,7.45,7.47,7.46,7.46,7.46,7.44,7.47,7.47,7.47,7.52,7.52,7.52,7.53,7.57,7.63,
							7.66,7.66,7.60,7.58,7.55,7.75,7.81,7.75,7.69,7.71,7.70,7.73,7.73,7.75,7.83,7.89,7.89,7.89,7.91,7.87,7.88,7.92,7.91,7.92,7.93,7.91,7.88,
							7.88,7.82,7.80,7.80,7.90,7.94,8.03,8.12,8.10,8.12,8.12,8.12,8.31,8.38,8.45,8.46,8.44,8.44,8.44,8.47,8.18,8.24,8.05,7.79,7.79,7.79,7.63, 7.68,
							7.74,7.72,7.67,7.67,7.67,7.58,7.76};

			double[] sirali = mergeSort(kur);
			int len = kur.Length;
			double maxDeger =sirali[len-1];
			double minDeger = sirali[0];
			int maxIndeks = Array.IndexOf(kur,maxDeger);
			int minIndeks = Array.IndexOf(kur, minDeger);


            /*for (int i = 0; i < kur.Length; i++)
            {
				Console.WriteLine(sirali[i]);
            }*/
            if (maxIndeks>minIndeks) //Alım satımdan önce mi kontrol etmek için
            {
				Console.WriteLine("Alım Yapılacak tarih: " + tarih[minIndeks]);
				Console.WriteLine("Satım Yapılacak tarih: " + tarih[maxIndeks]);
				Console.WriteLine("Kar miktarı:" + (maxDeger - minDeger));
				Console.ReadLine();
			}
			

		}
	}
}
