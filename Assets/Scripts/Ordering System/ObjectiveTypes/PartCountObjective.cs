using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture.Ordering
{
    [Serializable]
    public class PartCountObjective : BaseObjective
    {
        public int minNoOfParts = -1;
        public int maxNoOfParts = int.MaxValue;

        public override void Setup()
        {
            objectiveType = ObjectiveType.PartCount;
            base.Setup();
        }

        public override bool isMet(ContractHandler handler)
        {
            // temporarily store the values so they can be changed without interruputing the configuration
            int min = minNoOfParts;
            int max = maxNoOfParts;
            int value = handler.noOfPartsUsed;

            // store whether we are looking for a min or max value or both
            bool usingMin = true;
            bool usingMax = true;

            // check min is being used
            if (min < 0)
            {
                min = int.MinValue;
                usingMin = false;
            }

            // check max is being used
            if (max < 0)
            {
                max = int.MaxValue;
                usingMax = false;
            }

            // offer a default win if the values are incorrectly configured and log a warning
            if (!usingMin && !usingMax)
            {
                Debug.LogWarning($"Please check the configuration for {this.GetType()} in {handler.contract.name} as both the min and max values appear to be set to invalid values.");
                return true;
            }

            // if the value is within the min and max range return true
            if (value >= min && value <= max)
            {
                return true;
            }

            return false;
        }
    }
}