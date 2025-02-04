﻿using System.Xml.Serialization;

namespace CarDealer.DTO.Export_DTO
{
    [XmlType("part")]
    public class ExportPartCarsDTO
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}