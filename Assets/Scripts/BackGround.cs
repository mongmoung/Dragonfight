using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float scroolSpeed = 1f;
    private Material myMaterial;

    
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        Vector2 newOffset = myMaterial.mainTextureOffset;
        newOffset.Set(0, newOffset.y + (scroolSpeed + Time.deltaTime));
        
        myMaterial.mainTextureOffset = newOffset;   
    }
}
