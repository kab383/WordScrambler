using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordScrambler.Repository
{
    public class Words
    {
        // Properties
        public string ZooAnimals { get; set; }
        public string Presidents { get; set; }
        public string Countries { get; set; }
        public string Movies { get; set; }
        public string Foods { get; set; }
        public string Sports { get; set; }
        public string TvShows { get; set; }
        public string Brands { get; set; }
        public string Desserts { get; set; }

        public Words(string zooAnimals, string presidents, string countries, string movies, string foods, string sports, string tvShows, string brands, string desserts)
        {
            ZooAnimals = zooAnimals;
            Presidents = presidents;
            Countries = countries;
            Movies = movies;
            Foods = foods;
            Sports = sports;
            TvShows = tvShows;
            Brands = brands;
            Desserts = desserts;
        }
        // public Words(){}
        
    }

}