using UnityEngine;
using Yarn;
using Yarn.Unity;

public class CharacterChange : MonoBehaviour
{

    public GameObject NPC1;
    public GameObject NPC2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("change")]
    public void Change()
    {
        Debug.Log("change character");
        NPC1.SetActive(false);
        NPC2.SetActive(true);
    }
}
