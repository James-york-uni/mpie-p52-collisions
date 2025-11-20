using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject player; 
    // Update is called once per frame
    void Update()
    {
        float ammo = player.GetComponent<Collide>().ammo;
        Text t = GetComponent<Text>();
        t.text = ammo.ToString();
    }
}
