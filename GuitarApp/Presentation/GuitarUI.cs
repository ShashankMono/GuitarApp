using GuitarApp.Constants;
using GuitarApp.Controller;
using GuitarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Presentation
{

    internal class GuitarUI
    {
        public static void GuitarStore()
        {
            GuitarFeatures g1Features = new GuitarFeatures(Builder.FENDER,"Stratocastor",Types.ACOUSTIC,Wood.ALDER,Wood.ALDER,12);
            GuitarInventoryController.AddNewGuitar("V95693",1499.95,g1Features);

            GuitarFeatures g2Features = new GuitarFeatures(Builder.GIBSON, "Bass guitar", Types.ELECTRIC, Wood.INDIAN_ROSEWOOD, Wood.MAPLE, 6);
            GuitarInventoryController.AddNewGuitar("V98693", 1686.95, g2Features);

            GuitarFeatures g3Features = new GuitarFeatures(Builder.RYAN, "Harp guitar", Types.ACOUSTIC, Wood.COCOBOLO, Wood.SITKA, 30);
            GuitarInventoryController.AddNewGuitar("B923993", 1999.00, g3Features);

            GuitarFeatures g4Features = new GuitarFeatures(Builder.GIBSON, "Bass guitar", Types.ELECTRIC, Wood.INDIAN_ROSEWOOD, Wood.MAPLE, 6);
            GuitarInventoryController.AddNewGuitar("V983983", 1599.00, g4Features);

            GuitarFeatures ErineWants = new GuitarFeatures(Builder.GIBSON, "Bass guitar", Types.ELECTRIC, Wood.INDIAN_ROSEWOOD, Wood.MAPLE, 6);
            List<Guitar> guitars = GuitarInventoryController.SearchGuitar(ErineWants);

            if(guitars.Count == 0)
            {
                Console.WriteLine("No match found");
                return;
            }
            foreach (Guitar g in guitars)
            {
                GuitarFeatures feature = g.GetFeatures();
                Console.WriteLine($"\nSerial number : {g.GetSerialNumber()}\n" +
                    $"Price : {g.GetPrice()}\n" +
                    $"Builder : {feature.GetBuilder().ToString()}\n" +
                    $"Model : {feature.GetModel()}\n" +
                    $"Type : {feature.GetType().ToString()}\n" +
                    $"BackWood : {feature.GetBackWood().ToString()}\n" +
                    $"Number of strings : {feature.GetNumString()}\n" +
                    $"TopWood : {feature.GetTopWood().ToString()}\n");
            }
        }
    }
}
