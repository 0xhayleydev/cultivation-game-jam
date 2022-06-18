using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatInstancer : MonoBehaviour
{
    public Vector2 offset;
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = gameObject.GetComponent<MeshRenderer>().material;
    }
    // Update is called once per frame
    void Update()
    {
        mat.SetVector("_Seed", new Vector4(offset.x, offset.y));
        Debug.Log(mat.GetVector("_Seed"));
    }
}
