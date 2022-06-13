using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Furniture;

public class PlacementHandler : MonoBehaviour
{
    public static PlacementHandler singleton;
    public FurniturePart currentlyHeld;
    public LayerMask floorLayer;
    bool gridSnapping;

    // Start is called before the first frame update
    void Start()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else
        {
            Debug.LogWarning("There are two PlacementHolders in this scene. Please ensure there is only one.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveSelected();

        if (Input.GetKeyDown(KeyCode.Return))
        {
            gridSnapping = !gridSnapping;
        }
    }

    private void MoveSelected()
    {
        if (currentlyHeld != null)
        {
            RotateSelected();

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, 100f, floorLayer);

            if (hit.transform != null)
            {
                currentlyHeld.SetPosition(hit.point, gridSnapping);
            }
        }
    }

    private void RotateSelected()
    {
        if (Input.GetMouseButtonDown(1))
        {
            currentlyHeld.Rotate(Vector3.up, 90);
        }
    }

    public void SelectItem(FurniturePart selected)
    {
        if (currentlyHeld == null)
        {
            currentlyHeld = selected;
            currentlyHeld.gameObject.layer = 0;
        }
        else
        {
            currentlyHeld.gameObject.layer = 6;
            currentlyHeld = null;
        }
    }
}
