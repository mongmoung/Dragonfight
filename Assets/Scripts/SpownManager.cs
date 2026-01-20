using System.Collections.Generic;
using UnityEngine;

public class SpownManager : MonoBehaviour
{
    public GameObject enemy;

    public List<Enemy> enemies;
    private Dictionary< int ,Enemy> levelEnemy;

    int maxEnemy = 20;

    void Start()
    {
        InvokeRepeating("CreatEnenmy", 0.5f, 1);
    }

    void Update()
    {
        
    }

/*    private void SetEnemy()
    {
        if (enemies != null)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                levelEnemy.Add(i, enemies[i]);
            }
        }
        else
            Debug.Log("리스트가 비어있음");
    }

    private void CheckLevel(int level)
    {
        switch (level)
        { 
            case 0:
                //딕셔너리에 0번 몬스터가 나오게
        
        
        }


    }*/
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
