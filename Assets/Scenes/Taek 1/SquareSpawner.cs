using System.Drawing;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public Vector3 size = new Vector3(10,10,0);
    public Vector3 position = new Vector3(0, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = Input.mousePosition;
        
        if(Input.GetMouseButtonDown(0))
        {
            Gizmos.DrawCube(position, size);
        }
        
    }
}
