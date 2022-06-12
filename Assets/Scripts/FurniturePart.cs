using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture
{
    public enum PartType
    {
        Leg,
        Surface
    }

    public enum PartSize
    {
        Small,
        Medium,
        Large
    }

    public enum PartMaterialType
    {
        Wood,
        Metal
    }

    public class FurniturePart : MonoBehaviour
    {
        public PartType type;
        public PartSize size;
        public PartMaterialType materialStyle;

        public virtual void PlaceInScene()
        {

        }

        public void SetPosition(Vector3 position, bool gridSnapping = false)
        {
            Debug.Log("Running");
            if (gridSnapping)
            {
                position.x = Mathf.RoundToInt(position.x);
                position.y = Mathf.RoundToInt(position.y);
                position.z = Mathf.RoundToInt(position.z);
            }

            position.y += transform.localScale.y / 2;

            transform.position = position;
        }

        private void OnMouseDown()
        {
            PlacementHandler.singleton.SelectItem(this);
        }
    }
}
