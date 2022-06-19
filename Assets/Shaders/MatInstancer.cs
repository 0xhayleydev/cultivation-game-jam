using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatInstancer : MonoBehaviour
{
    public Vector4 offset;
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = gameObject.GetComponent<MeshRenderer>().material;
    }
    // Update is called once per frame
    void Update()
    {
        UpdateMaterial(mat);
    }

    void UpdateMaterial(Material material)
    {
        material.SetVector("_Seed", offset);
    }
}