using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    
    private int i;

    void Start()
    {
        i = 3; 
    }

    void Update()
    {
        i++;
        Debug.Log($"{gameObject.name}:{i}".Replace(" ", ""));
    }
}