using System.Drawing;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public Vector2 position = new Vector2(0, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = Input.mousePosition;
        Vector2 topLeft = position + new Vector2(position.x - 2, position.y + 2);
        Vector2 topRight = position + new Vector2(position.x + 2, position.y + 2);
        Vector2 bottomLeft = position + new Vector2(position.x - 2, position.y - 2);
        Vector2 bottomRight = position + new Vector2(position.x + 2, position.y - 2);
        Debug.DrawLine(topLeft, topRight);
        Debug.DrawLine(bottomLeft, bottomRight);
        Debug.DrawLine(topLeft, bottomLeft);
        Debug.DrawLine(topRight, bottomRight);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clap");
            Debug.DrawLine(topLeft, topRight);
            Debug.DrawLine(bottomLeft, bottomRight);
            Debug.DrawLine(topLeft, bottomLeft);
            Debug.DrawLine(topRight, bottomRight);
        }
        
    }
}
