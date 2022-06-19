using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture.Ordering
{
    [Serializable]
    public class StyleObjective : BaseObjective
    {
        public PartMaterial style;

        public override void Setup()
        {
            objectiveType = ObjectiveType.StyleRequirement;
            base.Setup();
        }

        public override bool isMet(ContractHandler handler)
        {
            return true;
        }
    }
}