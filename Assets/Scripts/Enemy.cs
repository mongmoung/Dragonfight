using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject effect;

    public float speed = 0.5f;
    private float distanceY;

    Vector2 vec = Vector2.down;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        distanceY = speed * Time.deltaTime;

        transform.Translate(vec * distanceY);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("bullet"))
        {
            Destroy (collision.gameObject);
            Destroy(gameObject);

            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);
        }
    }


}
