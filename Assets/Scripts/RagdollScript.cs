using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RagdollScript : MonoBehaviour
{
    public Slider mainSlider;
    public CameraShake cameraShake;
    ParticleSystem ps;

    [SerializeField] float MaxHealth = 100.0f;
    [HideInInspector] public float Health = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        Health = MaxHealth;
    }

    public void TakeDamage(float damage)
    {
        ps.Play();       

        if((Health - damage) > 0.0f)
        {
            Health -= damage;
        }
        else
        {
            Health = 0.0f;
            SceneManager.LoadScene(2);
        }

        mainSlider.value = Health;
        StartCoroutine(cameraShake.Shake(0.2f, 0.4f));
    }

    public void Heal(float HealAmount)
    {
        Health += HealAmount;
        mainSlider.value = Health;
    }
}
