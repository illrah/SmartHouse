﻿using System.Xml.Serialization;

namespace SmartHouse.Models.Logic
{
    [XmlInclude(typeof(GroupEvent))]
    [XmlInclude(typeof(UIDEvent))]
    public class Event: BaseEntity<int>
    {
        public byte InputID { get; set; }
    }
}
