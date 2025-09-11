using System.Drawing;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public Vector2 position = new Vector2(0, 0);
    public GameObject Square;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = Input.mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clap");
            Ray ray = Camera.main.ScreenPointToRay(position);
            Vector3 spawnPos = ray.GetPoint(10f);
            Instantiate(Square, spawnPos, Quaternion.identity);
            
            Debug.Log(position.x);
            Debug.Log(position.y);  
        }
        
    }
}
