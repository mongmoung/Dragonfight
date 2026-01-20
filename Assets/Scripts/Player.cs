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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            //적 삭제
            Destroy(collision.gameObject);

            //플레이어 삭제
            Destroy(gameObject);


        }
    }
}
