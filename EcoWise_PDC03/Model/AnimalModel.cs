using System;
using System.Collections.Generic;
using System.Text;

namespace EcoWise_PDC03.Model
{
    public class AnimalModel
    {
        public int id { get; set; }
        public string AnimalCode { get; set; }
        public string InitialIdentification { get; set; }
        public string Kingdom { get; set; }
        public string Class { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string ScientificName { get; set; }
        public string Taxonomy { get; set; }
        public string Characteristics { get; set; }
        public string Habitat { get; set; }
        public string Threats { get; set; }
        public string Conservation { get; set; }
    }
}
