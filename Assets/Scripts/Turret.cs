using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

    public float turretSpeed = 150f;
    public Transform turretPosition;
    public float bulletSpeed;
    public Rigidbody bulletPrefab;

    Vector3 turretEulers;

    private Inventory inventory;


    void Awake()
    {
        inventory = GetComponent<Inventory>();
    }
    
	// Use this for initialization
	void Start () {
        turretEulers = turretPosition.transform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
        TurretMove();
        Shoot();
	}

    private void TurretMove()
    {
        float x = turretEulers.x - (Input.GetAxis("Mouse Y") * turretSpeed * Time.deltaTime);

        if (x > 45 && x < 90)
            turretEulers.x = x;

        turretEulers.y += (Input.GetAxis("Mouse X") * turretSpeed * Time.deltaTime);
        turretPosition.transform.eulerAngles = turretEulers;
    }

    void Shoot()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && inventory.myAmmo.bullets > 0)
        {
            float tipOffset = turretPosition.transform.localScale.y / 2 + 5f;
            Vector3 tipPoint = turretPosition.transform.TransformPoint(new Vector3(0, tipOffset, 0));

            Rigidbody bulletInstance = Instantiate(bulletPrefab, tipPoint, turretPosition.rotation) as Rigidbody;
            bulletInstance.AddForce(turretPosition.up * bulletSpeed);
            inventory.myAmmo.bullets--;
            GameObject.Find("AmmoText").guiText.text = "Ammo: " + inventory.myAmmo.bullets;
        }
    }
}
