using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture
{
    public enum PartComponent
    {
        None,
        Leg,
        Surface
    }

    public enum PartSize
    {
        None,
        Small,
        Medium,
        Large
    }

    public enum PartMaterial
    {
        None,
        Wood,
        Metal
    }

    public enum FurnitureWhole
    {
        None,
        Table,
        Chair,
        Bed,
        Sofa,
        Shelf,
        Bench,
        Stool
    }
}