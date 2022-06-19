using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Furniture
{
    public class FurniturePartController : MonoBehaviour
    {
        public FurniturePart part;

        public virtual void PlaceInScene()
        {

        }

        public void SetPosition(Vector3 position, bool gridSnapping = false)
        {
            if (gridSnapping)
            {
                position.x = Mathf.RoundToInt(position.x);
                position.y = Mathf.RoundToInt(position.y);
                position.z = Mathf.RoundToInt(position.z);
            }

            position.y += transform.localScale.y / 2;

            transform.position = position;
        }

        public void Rotate()
        {
            transform.localEulerAngles += Vector3.up * 90;
        }

        private void OnMouseDown()
        {
            PlacementHandler.singleton.SelectItem(this);
        }
    }
}
