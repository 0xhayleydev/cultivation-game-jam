using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;
    public Vector2 cameraHeightBounds;
    public Vector3 rotateDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CameraMovement();
    }

    void CameraMovement()
    {
        transform.LookAt(Vector3.zero);
        rotateDirection = Vector3.zero;

        rotateDirection += -transform.up * Input.GetAxis("Horizontal");
        rotateDirection += transform.right * Input.GetAxis("Vertical");

        Vector3 position = transform.position;
        if (position.y < cameraHeightBounds.x)
        {
            position.y = cameraHeightBounds.x;
        }
        else if (position.y > cameraHeightBounds.y)
        {
            position.y = cameraHeightBounds.y;
        }

        transform.position = position;

        transform.position += transform.forward * Input.GetAxis("Mouse ScrollWheel");

        transform.RotateAround(Vector3.zero, rotateDirection, speed * Time.deltaTime);
    }
}
