using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>())
            gameObject.SetActive(false);
    }

    //화면밖에 나갈시를 감지하는 메서드
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

}
