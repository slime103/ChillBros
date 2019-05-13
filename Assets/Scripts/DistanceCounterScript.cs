using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCounterScript : MonoBehaviour
{

    public float distance;
    public Text distanceText;

    // Start is called before the first frame update
    void Start()
    {
        distance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        distance += 15 * Time.deltaTime;
        distanceText.text = "Distance: " + ((int)distance).ToString();
    }
}
