using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        InvokeRepeating("Shoot", 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Shoot()
    {
        Instantiate(bullet,transform.position,Quaternion.identity);
    }
}
