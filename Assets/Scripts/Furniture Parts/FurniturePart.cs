using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture
{
    public class FurniturePart : ScriptableObject
    {
        public PartComponent component;
        public PartSize size;
        public PartMaterial material;
    }
}