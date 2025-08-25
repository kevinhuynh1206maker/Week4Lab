using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    void Start() 
    {
        Application.targetFrameRate = 60;
        Instantiate(redObj,  new Vector3( 2.2f, 0f, 0f), Quaternion.identity);
        Instantiate(blueObj, new Vector3(-2.2f, 0f, 0f), Quaternion.identity);
    }
}