using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture.Ordering
{
    public class BaseObjective
    {
        public enum ObjectiveType
        {
            None,
            FurnitureType,
            TimeLimit,
            PartCount,
            SizeRequirement,
            StyleRequirement,
            PartRequirement
        }

        string name = "";
        [HideInInspector] public ObjectiveType objectiveType;
        public bool activeObjective = false;

        public virtual void Setup()
        {
            name = objectiveType.ToString();
        }

        public virtual bool isMet(ContractHandler handler)
        {
            return false;
        }
    }
}