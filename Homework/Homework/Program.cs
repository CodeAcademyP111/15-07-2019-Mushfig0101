using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program

        
    {
      

        public delegate string Natural(int number);
        static void Main(string[] args)
        {

            Payment payment = new Payment(1580);
            payment.PaySystem += delegate (float a, int b)
            {
                Console.WriteLine($"Hesabinizda istediyiniz mebleg yoxdur.");
            };
            payment.GetQuiz(986);

            //Conpare conpare = new Conpare();
            //natural = conpare.Check(15);
            //natural += conpare.SadeEded(20);
            //natural += conpare.TekCut(13);
            //Burda Problemim var

           


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
                    PaySystem.Invoke(Money, q);
                }
            }
        }


        public class Conpare
        {
            public int Number { get; private set; }

            public string Check(int num)
            {
                if (num >= 0)
                {

                    return $"{num} menfi ededdir";
                }
                else
                {

                    return $"{num} musbet ededdir";
                }


            }

            public string SadeEded(int num1)
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
                    return $"{num1} sade eded deyil ";
                }
                else
                {
                    return $"{num1} sade ededdir";
                }
            }

            public string TekCut(int num2)
            {
                if (num2 % 2 == 0)
                {
                    return $"{num2} cut ededdir";
                }
                else
                {
                    return $"{num2} Tek ededdir";
                }
            }


        }
    }
}

