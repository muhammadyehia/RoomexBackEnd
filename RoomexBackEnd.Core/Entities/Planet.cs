using System;

namespace RoomexBackEnd.Core.Entities
{
    public class Planet
    {
        public Guid PlanetId { get; set; }
        public string Name { get; set; }
        public long Distance { get; set; }
        public override bool Equals(object obj)
        {
            if(obj is Planet)
            {
                var dis = obj as Planet;
                return (dis.Name == Name && dis.PlanetId == PlanetId && dis.Distance == Distance);
            }
            return false;
        }
    }
}
