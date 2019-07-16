using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program

        
    {
      

        static void Main(string[] args)
        {

            Payment payment = new Payment(1580);
            payment.PaySystem += delegate (float a, int b)
            {
                Console.WriteLine($"Hesabinizda istediyiniz mebleg yoxdur.");
            };
            payment.GetQuiz(986);

            Conpare conpare = new Conpare();
         
            //Burda Problemim var
            Action<int> welcome = conpare.Check;
            welcome += conpare.SadeEded;
            welcome += conpare.TekCut;
            welcome(15);




        }
        
        public class Payment
        {
            public event Action<float, int> PaySystem;
            public float Money { get; private set; }

            public Payment(float m)
            {
                Money = m;
            }

            public void GetQuiz(int q)
            {
                if (Money >= q)
                {
                    Console.WriteLine($"Hesabinizdan {q} AZN mebleg silindi: Hesabinizin qaligi {Money - q}  ");

                }
                else
                {
                    PaySystem?.Invoke(Money, q);
                    //? sonradan yazdim
                }
            }
        }


        public class Conpare
        {
           

            public void Check(int num)
            {
                if (num >= 0)
                {

                    Console.WriteLine($"{num} musbet ededdir");
                }
                else
                {
                    Console.WriteLine($"{num} menfi ededdir");

                }


            }

            public void SadeEded(int num1)
            {

                int count = 0;
                for (int i = 1; i <= num1; i++)
                {

                    if (num1 % i == 0)
                    {
                        count++;
                    }

                }

                if (count > 2)
                {
                    Console.WriteLine($"{num1} sade eded deyil "); 
                }
                else
                {
                    Console.WriteLine($"{num1} sade ededdir"); 
                }
            }

            public void TekCut(int num2)
            {
                if (num2 % 2 == 0)
                {
                    Console.WriteLine($"{num2} cut ededdir"); 
                }
                else
                {
                    Console.WriteLine($"{num2} Tek ededdir"); 
                }
            }


        }
    }
}

