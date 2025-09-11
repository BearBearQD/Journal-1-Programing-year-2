using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class SquareSpawner : MonoBehaviour
{
    public Vector2 position = new Vector2(0, 0);
    public GameObject Square;
    public float scaleSpeed;
    public float minScale = 0.2f;
    public float maxScale = 5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(position);
        Vector3 spawnPos = ray.GetPoint(10f);


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clap");
            Instantiate(Square, spawnPos, Quaternion.identity);
            
            Debug.Log(position.x);
            Debug.Log(position.y);  
        }

        Square.transform.position = spawnPos;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
        }
        Square.transform.localScale = new Vector3(Mathf.Clamp(scroll, minScale, maxScale), Mathf.Clamp(scroll, minScale, maxScale), 2);



    }
}
