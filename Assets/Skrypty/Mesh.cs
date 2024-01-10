using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesh : MonoBehaviour
{
    public Vector3[] newVertices;
    public Vector2[] newUV;
    public int[] newTriangles;
    UnityEngine.Mesh mesh;

   void Start()
    {
        mesh = new UnityEngine.Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
    }
    void Update()
    {
        mesh.vertices = newVertices;
        mesh.uv = newUV;
        mesh.triangles = newTriangles;
    }
}