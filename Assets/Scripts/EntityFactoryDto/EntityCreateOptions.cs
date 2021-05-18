using Core.MapDto;
using UnityEngine;

namespace EntityFactoryDto
{
    public class EntityCreateOptions
    {
        public EntityType EntityType { get; set; }
        public Vector2 Position { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
    }
}