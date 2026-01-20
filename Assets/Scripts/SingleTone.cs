using UnityEngine;

public class SingleTone : MonoBehaviour
{
    public static SingleTone instance;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
