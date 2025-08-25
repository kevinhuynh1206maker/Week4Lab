using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    
    private int i;

    private int blueDisableFrame;
    
    void Awake()
    {
        if (rend == null) rend = GetComponent<Renderer>();
    }
    void Start()
    {
        i = 3; 
        blueDisableFrame = Random.Range(150, 251);
    }

    void Update()
    {
        i++;
        Debug.Log($"{gameObject.name}:{i}".Replace(" ", ""));
        if (CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        if (CompareTag("Blue") && i == blueDisableFrame)
        {
            rend.enabled = false;
        }
    }
}