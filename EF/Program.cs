using System;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new MyDbContext())
            {
               
                Uye Uye = new Uye();
                Uye.ad = "deneme";
                context.Uye.Add(Uye);
                context.SaveChanges();

            }

        }
    }


   

   



}
