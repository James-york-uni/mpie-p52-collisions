using UnityEngine;

public class open : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter() {
        GameObject parent = transform.parent.gameObject;       
        Animation animation = parent.GetComponent<Animation>();    
        AudioSource doorOpen = GetComponent<AudioSource>(); 
        doorOpen.Play();   
        animation.Play("OpenDoor");
        
    }
}
