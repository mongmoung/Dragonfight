using System.Collections.Generic;
using UnityEngine;

public class SpownManager : MonoBehaviour
{
    public GameObject enemy;
    List<Enemy> enemys;

    int maxEnemy = 20;

    void Start()
    {
        InvokeRepeating("CreatEnenmy", 0.5f, 1);
    }

    void Update()
    {
        
    }

    private void CreatEnenmy()
    {
        float height = Camera.main.orthographicSize;
        float Width = height * Screen.width / Screen.height;
        float halfWidth = height * Screen.width / Screen.height;

        float leftX = -halfWidth;
        float randomX =  Random.Range(leftX, Width);

        GameObject monster = Instantiate(enemy , new Vector3(randomX, height, 0), Quaternion.identity );
/*        for(int i = 0; i < maxEnemy; i++)
        {
            if(monster.TryGetComponent<Enemy>(out Enemy clone))
            {
                enemys.Add(clone);
            }
        }*/
    }

    public void SpownEnemy()
    {

    }
}
