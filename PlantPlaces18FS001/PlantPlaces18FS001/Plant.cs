using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlantPlaces18FS001
{
    public class Plant
    {
        private int id;
        private string genus;
        private string species;
        private string cultivar;
        private string common;

        public int Id { get => id; set => id = value; }
        public string Genus { get => genus; set => genus = value; }
        public string Species { get => species; set => species = value; }
        public string Cultivar { get => cultivar; set => cultivar = value; }
        public string Common { get => common; set => common = value; }
    }
}