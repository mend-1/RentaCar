using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace RentaCar
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarTest();


        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDAL());

            carManager.Add(new Car { Id = 12, BrandId = 3, ColorId = 2, ModelYear = 2021, DailyPrice = 500, Description = "BMW", });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);

            }
        }
    }
}