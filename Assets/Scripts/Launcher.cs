using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Bullet bullet;
    private List<Bullet> bullets = new List<Bullet>();

    private int maxCount = 20;

    void Start()
    {
        CreatBulletPool();
        StartCoroutine(ShootCo());
    }

    private void CreatBulletPool()
    {
        for (int i = 0; i < maxCount; i++)
        {
            Bullet clonBuller = Instantiate(bullet, transform.position, Quaternion.identity);
            clonBuller.gameObject.SetActive(false);
            bullets.Add(clonBuller);
        }
    }

    private Bullet GetBullet()
    {
        foreach (Bullet bullet in bullets)
        {
            if (bullet.gameObject.activeSelf == false)
            {
                bullet.transform.position = transform.position;
                bullet.transform.rotation = Quaternion.identity;
                return bullet;
            }
        }
        return null;
    }

    public IEnumerator ShootCo()
    {       
        while (true)
        {
            Bullet useBullet = GetBullet();
            useBullet.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
        }

    }

}
