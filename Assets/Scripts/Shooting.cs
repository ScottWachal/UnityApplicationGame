using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    
    
    private Inventory inventory;
    
    
    void Awake ()
    {
        inventory = GetComponent<Inventory>();
    }
    
    
    void Update ()
    {
        Shoot();
    }
    
    
    void Shoot ()
    {
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && inventory.myStuff.bullets > 0)
        {
			float tipOffset = firePosition.transform.localScale.y/2 + 5f;
            Vector3 tipPoint = firePosition.transform.TransformPoint(new Vector3(0, tipOffset, 0));

            Rigidbody bulletInstance = Instantiate(bulletPrefab, tipPoint, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.up * bulletSpeed);
            
            inventory.myStuff.bullets--;
        }
    }
}