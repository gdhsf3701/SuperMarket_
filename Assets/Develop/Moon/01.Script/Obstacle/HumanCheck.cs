using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer), typeof(MeshCollider))]
public class HumanCheck : MonoBehaviour
{
    public int segments = 18;
    public float radius = 1f;
    public float height = 2f;

    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        MeshCollider meshCollider = GetComponent<MeshCollider>();
        meshFilter.mesh = CreateConeMesh();
        meshCollider.sharedMesh = meshFilter.mesh;
        meshCollider.convex = true;
        meshCollider.isTrigger = true;
    }

    Mesh CreateConeMesh()
    {
        Mesh mesh = new Mesh();

        // Vertices
        Vector3[] vertices = new Vector3[segments + 2];
        vertices[0] = Vector3.zero; // Bottom center
        for (int i = 0; i < segments; i++)
        {
            float angle = 2 * Mathf.PI * i / segments;
            vertices[i + 1] = new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius);
        }
        vertices[segments + 1] = new Vector3(0, height, 0); // Top point

        int[] triangles = new int[segments * 3 * 2];
        for (int i = 0; i < segments; i++)
        {
            triangles[i * 3] = 0;
            triangles[i * 3 + 1] = (i + 1) % segments + 1;
            triangles[i * 3 + 2] = i + 1;

            triangles[segments * 3 + i * 3] = i + 1;
            triangles[segments * 3 + i * 3 + 1] = (i + 1) % segments + 1;
            triangles[segments * 3 + i * 3 + 2] = segments + 1;
        }

        Vector3[] normals = new Vector3[vertices.Length];
        normals[0] = Vector3.down;
        for (int i = 1; i <= segments; i++)
        {
            normals[i] = Vector3.up;
        }
        normals[segments + 1] = Vector3.up;

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.normals = normals;

        return mesh;
    }
}
