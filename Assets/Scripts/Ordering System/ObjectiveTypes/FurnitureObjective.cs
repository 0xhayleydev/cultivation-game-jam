using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture.Ordering
{
    [Serializable]
    public class FurnitureObjective : BaseObjective
    {
        public FurnitureWhole furnitureToCreate;
        public override void Setup()
        {
            activeObjective = true;
            objectiveType = ObjectiveType.FurnitureType;
            base.Setup();
        }

        public override bool isMet(ContractHandler handler)
        {
            return true;
        }
    }
}
