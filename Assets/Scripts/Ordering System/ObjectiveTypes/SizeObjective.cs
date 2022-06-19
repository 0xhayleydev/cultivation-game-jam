using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture.Ordering
{
    [Serializable]
    public class SizeObjective : BaseObjective
    {
        public PartSize partSize;

        public override void Setup()
        {
            objectiveType = ObjectiveType.PartRequirement;
            base.Setup();
        }

        public override bool isMet(ContractHandler handler)
        {
            return true;
        }
    }
}