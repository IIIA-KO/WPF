using System;

using System.Runtime.Serialization;

namespace HW12.Models
{
    [DataContract]
    [Serializable]
    internal class Car
    {
        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public double Motor { get; set; }

        [DataMember]
        public DateTime ReleaseDate { get; set; }

        [DataMember]
        public string StateNumber { get; set; }

        [DataMember]
        public string VIN { get; set; }

        public override string ToString() =>
            $"| {Brand,10} | {Model,10} | {Motor,4} | {ReleaseDate.ToShortDateString()} | {StateNumber,8} | {VIN,20} |";
    }
}
