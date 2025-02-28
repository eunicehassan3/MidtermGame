using UnityEngine;

public class ClawBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Camera cam;
    private Vector3 mousePosG;
    private float currentSpeed;
    public static bool isHOlding;
    private GameObject chosenOne; ////
    public GameObject[] candy;
    public static int count;

    void Start()
    {
        cam = Camera.main;
        currentSpeed = 15.0f;
        isHOlding = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >=-3.05f && transform.position.x <= 2.00f)
        {
            mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 newPos = new Vector2(mousePosG.x, transform.position.y);
            transform.position = newPos;
        }

        if(transform.position.x < -3.05f){
            transform.position = new Vector2(-3.03f, transform.position.y);
        }

        if(transform.position.x > 2.00f){
            transform.position = new Vector2(1.98f, transform.position.y);
        }

        if(Input.GetMouseButtonDown(0)){
            Instantiate(candy[Random.Range(0,candy.Length)], transform.position, Quaternion.identity);
            count += 1;
        }
        

    }
}
