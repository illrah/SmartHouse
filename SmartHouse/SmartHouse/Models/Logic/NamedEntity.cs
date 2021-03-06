﻿using System;
using System.Collections.Generic;
using System.Text;
using SmartHouse.Services;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace SmartHouse.Models.Logic
{
    public class NamedEntity<T>: BaseEntity<T>
    {
        // [XmlIgnore]
        private string name;

        // [XmlAttribute("Name")]
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
