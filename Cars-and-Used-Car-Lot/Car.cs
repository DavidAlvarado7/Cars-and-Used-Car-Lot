using System;
namespace Cars_and_Used_Car_Lot
{
	public class Car
	{
		public string Make { get; set; }

		public string Model { get; set; }

		public int Year{ get; set;  }

		public decimal Price{ get; set; }

		public Car()
		{
			Make = string.Empty;
			Model = string.Empty;
			Year = 0;
			Price = 0;


		}

		public Car(string make, string model, int year, decimal price)
		{
			Make = make;
			Model = model;
			Year = year;
			Price = price;



		}

        public override string ToString()
        {
            return $"{Make}    {Model}	 Year: {Year}	price: ${Price}"; 

        }
    }


	public class UsedCars : Car
	{

		public double Mileage { get; set; }


		public UsedCars(string make, string model, int year, decimal price, double mileage)
		{
			Make = make;
			Model = model;
			Year = year;
			Price = price;
			Mileage = mileage;

			

		}

        public override string ToString()
        { 
			return $"{Make}    {Model}  Year: {Year}  Price:   ${Price}      Mileage: {Mileage}";
        }

    }


	

		
}

