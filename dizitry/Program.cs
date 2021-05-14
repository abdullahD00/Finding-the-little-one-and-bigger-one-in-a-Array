using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizitry
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayılar = new int[5];
            // [0]   [1]    [2]   [3]   [4]   
            // Toplam istediğin eleman sayısını tanımlıyorsun, bir eksiği kadar ını yazarak kullanıyorsun.. 

           for(int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ". sayıyı giriniz:");
                sayılar[i] = Convert.ToInt32(Console.ReadLine());
                
               //bu for döngüsü kullanıcıdan veri almak için
            }
            
            Array.Sort(sayılar);
           //array dizi demek zaten. sort diyerek küçükten büyüğe içindeki sayıları sıralıyor. (array.reserve )dersen tam tersi olarak sıralar.
            foreach(int i in sayılar)
            {
                Console.WriteLine(i);

                //bu döngü dizilerde dizi içinde aritmetik işlemler kullanmak için kullanılıyor çoğunlukla.
                //parametresi i değişkenini sayılar dan seç anlamında. burda diziyi yazdırmak için kullanılmış.
            }
                Console.WriteLine();
            
                
            
                Console.Write("dizinin en büyüğü:{0}", sayılar[sayılar.Length - 1] );
                Console.WriteLine();
                Console.Write("dizinin en küçüğü:{0}", sayılar[0]);
            
            //sayılar.length deki length uzunluğu belirtir.uzunluğu üzerinden işlem yaparken kullanılır.
                Console.Read();







        }
    }
}
