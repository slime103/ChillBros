using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollScript : MonoBehaviour
{
    [SerializeField] float MaxHealth = 100.0f;
    [HideInInspector] public float Health = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        if((Health - damage) > 0.0f)
        {
            Health -= damage;
        }
        else
        {
            Health = 0.0f;
            //End game
        }

        Debug.Log(Health);
    }
}
