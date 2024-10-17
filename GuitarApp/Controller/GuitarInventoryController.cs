using GuitarApp.Constants;
using GuitarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Controller
{
    internal class GuitarInventoryController
    {
        static LinkedList<Guitar> guitars = new LinkedList<Guitar>();

        public static void AddNewGuitar(string serialN, double price, GuitarFeatures feature)
        {
            guitars.AddLast(new Guitar(serialN, price, feature));
        }

        public static List<Guitar> SearchGuitar(GuitarFeatures guitarToBeSearched)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach(Guitar guitar in guitars)
            {
                GuitarFeatures guitarFeature = guitar.GetFeatures();
                if (!guitarFeature.Matches(guitarToBeSearched))
                    continue;

                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        } 

        public Guitar GetGuitar(string serialN)
        {
            foreach (Guitar guitar in guitars)
            {
                string serialNumber = guitar.GetSerialNumber().ToLower();
                if (serialN != null && serialN != "" && !serialNumber.Equals(serialN.ToLower()))
                    continue;
                return guitar;
            }
            return null;
        }
    }
}
