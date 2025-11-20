using UnityEngine;
using UnityEngine.UI; 

public class Grey : MonoBehaviour
{
    public GameObject player; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject crosshair = image.Crosshair; 
        float ammo = player.GetComponent<Collide>().ammo;
        if(ammo == 0) {
            crosshair.GetComponent<Crosshair>().color = new Color32(0, 0, 0, 100);
        }
        else {
            crosshair.GetComponent<Crosshair>().color = new Color32(255, 255, 255, 255);
        }
    }
}
