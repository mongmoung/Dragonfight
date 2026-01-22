using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ParticleSystem effect;

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
        if (collision.gameObject.GetComponent<Bullet>())
        {
            Destroy(gameObject);
            Die();
        }
    }

    private void Die()
    {
        ParticleSystem go = Instantiate(effect, transform.position, Quaternion.identity);
        gameObject.SetActive (false);
        GameManager.Instance.AddScore(+10);
    }

}
