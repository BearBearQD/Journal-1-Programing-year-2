using System.Drawing;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class SquareSpawner : MonoBehaviour
{
    public Vector2 position = new Vector2(0, 0);
    public GameObject Square;
    public GameObject SquareMove;
    public float scaleSpeed = 0.1f;
    Vector2 mousescroll = new Vector2(0,0);
    float x;
    float y;


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
        mousescroll = Input.mouseScrollDelta;
        x += mousescroll.y;
        y += mousescroll.y;
        SquareMove.transform.localScale = new Vector2(x, y);
        if (x > 4)
        {
            x = 4;
        }
        if (x < 0.1f)
        {
            x = 0.1f;
        }
        if(y < 4)
        {
            y = 4;
        }
        if(y < 0.1f)
        {
            y = 0.1f;
        }

        SquareMove.transform.position = spawnPos;



    }
}
