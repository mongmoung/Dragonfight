using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.8f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }


    //화면밖에 나갈시를 감지하는 메서드
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
