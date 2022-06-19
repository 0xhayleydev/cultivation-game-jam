using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture.Ordering
{
    [Serializable]
    public class TimeObjective : BaseObjective
    {
        public float timeLimit;

        public override void Setup()
        {
            objectiveType = ObjectiveType.TimeLimit;
            base.Setup();
        }

        public override bool isMet(ContractHandler handler)
        {
            return true;
        }
    }
}