using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3;

    void Start()
    {
        
    }

    void Update()
    {
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(distanceX, 0, 0);
    }
}
