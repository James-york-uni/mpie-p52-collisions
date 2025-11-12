using UnityEngine;

public class Collide : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float ammo = 0;
    // Update is called once per frame
    void Update()
    {
        Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));
        if(Input.GetKeyDown (KeyCode.Mouse0)) {
            if(ammo == 0) {
               AudioSource gunEmpty = GetComponent<AudioSource>(); 
               gunEmpty.Play();
            }
            if(ammo > 0) {
                ammo --; 
            RaycastHit result; 
            Physics.Raycast(ray, out result);
            GameObject g = result.collider.gameObject;
            if(result.collider.gameObject.name == "Target") {
                Animation a = g.transform.parent.GetComponent<Animation>();
                a.Play("LowerBridge");
            }
        }
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "AmmoBox") {
            AudioSource gunEmpty = GetComponent<AudioSource>(); 
            gunEmpty.Play();
            ammo += 20;
            other.gameObject.SetActive(false);   
        }
    }
}
