using UnityEngine;
using System.Collections;


public class Inventory : MonoBehaviour
{
    public class Ammo
    {
        public int bullets;
        
        public Ammo(int bul)
        {
            bullets = bul;
        }

        public Ammo()
            : this(50)
        {
           
        }
    }
    
    public Ammo myAmmo = new Ammo();
    
    void Start()
    {
        Debug.Log(myAmmo.bullets); 
    }
}
