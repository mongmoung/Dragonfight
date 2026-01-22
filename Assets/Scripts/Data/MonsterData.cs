using UnityEngine;

[CreateAssetMenu(fileName = "MonsterData", menuName = "Scriptable Objects/MonsterData")]
public class MonsterData : ScriptableObject
{
    [Header("기본 정보")]
    public int monsterNum;
    public int hp;
    public float speed;

    [Header("시각 요소")]
    public Sprite monsterSprite; 
    public ParticleSystem effct;
}
