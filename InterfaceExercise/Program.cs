using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common. - DONE
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; } - DONE
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. - DONE
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car viper = new Car();
            viper.Name = "Dodge Viper";
            viper.HasTrunk = true;
            viper.NumberOfTires = 4;
            viper.HasBreakPedal = true;
            viper.HasGasPedal = true;
            viper.HasEngine = true;
            viper.IsLowToGround = true;
            viper.Logo = "Snake";
            viper.SalesTeam = "Aggressive";

            Truck f150 = new Truck();
            f150.Name = "Ford F150";
            f150.NumberOfTires = 4;
            f150.Logo = "Ram";
            f150.SalesTeam = "Skilled";
            f150.HasLargeTires = true;
            f150.HasGasPedal = true;
            f150.HasEngine = true;
            f150.HasOpenTrunk = true;
            f150.HasBreakPedal = true;

            SUV wrangler = new SUV();
            wrangler.Name = "Jeep Wrangler";
            wrangler.NumberOfTires = 4;
            wrangler.IsOffRoad = true;
            wrangler.HasEnclosedTrunk = true;
            wrangler.HasGasPedal = true;
            wrangler.HasEngine = true;
            wrangler.HasBreakPedal = true;
            wrangler.SalesTeam = "Friendly";
            wrangler.Logo = "Mountains";

            viper.PrintDetails();
            Console.WriteLine("--------------------");
            f150.PrintDetails();
            Console.WriteLine("--------------------");
            wrangler.PrintDetails();


        }
    }
}
