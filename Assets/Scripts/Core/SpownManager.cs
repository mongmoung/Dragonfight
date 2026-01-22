using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class SpownManager : MonoBehaviour
{

    public List<Enemy> enemys;
    private Dictionary< int ,Enemy> levelEnemy = new Dictionary<int, Enemy>();

    int curCount = 0;
    int maxCount = 20;

    void Start()
    {
        SetEnemy();
        StartCoroutine(SpownCo(0));
    }

    private void SetEnemy()
    {
        if (enemys != null)
        {
            for (int i = 0; i < enemys.Count; i++)
            {
                levelEnemy.Add(i, enemys[i]);
            }
        }
        else
            Debug.Log("리스트가 비어있음");
    }


    private void CreatEnenmy(Enemy enemy)
    {
        float height = Camera.main.orthographicSize;
        float Width = height * Screen.width / Screen.height;
        float halfWidth = height * Screen.width / Screen.height;

        float leftX = -halfWidth;
        float randomX =  Random.Range(leftX, Width);

        Enemy monster = Instantiate(enemy , new Vector3(randomX, height, 0), Quaternion.identity );
    }

    private IEnumerator SpownCo(int level)
    {
        float waitSpown = 1.5f;

        while(curCount <= maxCount)
        {
            levelEnemy.TryGetValue(level, out Enemy monster);
            for (int i = 0; i < maxCount; i++)
            {
                CreatEnenmy(monster);
                yield return new WaitForSeconds(waitSpown);
                curCount++;
            }
        }
        curCount = 0;
    }

}
