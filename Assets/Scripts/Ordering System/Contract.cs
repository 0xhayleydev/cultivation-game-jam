using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture.Ordering
{
    [CreateAssetMenu(fileName = "FurnitureContract", menuName = "FurnitureContract", order = 0)]
    public class Contract : ScriptableObject
    {
        [Header("Contract:")]
        public FurnitureObjective furniture;

        [Space(10, order = -10)]
        [Header("Contract Objectives:")]
        public int numberOfObjectives;
        public List<BaseObjective> objectives;
        public PartCountObjective partCounts;
        public List<PartObjective> parts;
        public List<SizeObjective> sizes;
        public List<StyleObjective> styles;
        public TimeObjective timeLimit;

        private void SetupObjectives()
        {
            List<BaseObjective> activeObjectives = new List<BaseObjective>();
            foreach (BaseObjective o in objectives)
            {
                if (o.activeObjective)
                {
                    o.Setup();
                    activeObjectives.Add(o);
                }
            }

            objectives = activeObjectives;
            numberOfObjectives = objectives.Count - 1;
        }

        [ContextMenu("Save Objectives")]
        public void SaveObjectives()
        {
            objectives = new List<BaseObjective>();

            objectives.Add(furniture);
            objectives.Add(timeLimit);
            objectives.Add(partCounts);
            objectives.AddRange(parts);
            objectives.AddRange(sizes);
            objectives.AddRange(styles);

            SetupObjectives();
        }

        private void OnValidate()
        {
            if (objectives != null)
            {
                numberOfObjectives = objectives.Count - 1;
            }
            else
            {
                numberOfObjectives = 0;
            }
            furniture.activeObjective = true;
        }
    }
}
