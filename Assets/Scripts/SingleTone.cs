using Unity.VisualScripting;
using UnityEngine;

public class SingleTone<T> : MonoBehaviour where T : SingleTone<T>
{
    public static T Instance;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = (T)this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

}
