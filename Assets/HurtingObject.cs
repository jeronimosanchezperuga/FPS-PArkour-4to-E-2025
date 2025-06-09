using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObject : MonoBehaviour
{
    public int damagePoints;
    public HealthManager healthManager;

    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //restar damagepOints a la salud del player
            healthManager.UpdateHealth(-damagePoints);
        }
    }
  
}
