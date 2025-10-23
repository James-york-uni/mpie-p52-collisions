using UnityEngine;

public class Collide : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float Ammo = 0;
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        Ammo += 20;
        GameObject.SetActive(false);   
    }
}
