﻿using System;
using System.Xml.Serialization;

namespace SwitchvoxAPI
{
    public class CallLogEvent
    {
        /// <summary>
        /// The time the event occurred.
        /// </summary>
        [XmlAttribute("start_time")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// The type of event that occurred.
        /// </summary>
        [XmlAttribute("type")]
        public CallEventType Type { get; set; }

        /// <summary>
        /// Details of what happened in the event.
        /// </summary>
        [XmlAttribute("display")]
        public string Details { get; set; }

        public override string ToString()
        {
            return Details;
        }
    }
}
