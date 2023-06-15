using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class CupCollisionHandler : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public TextMeshProUGUI pointsCounterText;
    public int pointsCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves the object you want to detect collisions with
        if (collision.gameObject.CompareTag("PingPongBalls"))
        {
            // Trigger your desired actions here
            Debug.Log("Collision detected!");
            pointText.text = "+1 Point";
            pointsCounter += 1;
            pointsCounterText.text = "Points: " + pointsCounter;

            yield return new WaitForSeconds(2f);

            pointText.text = "";
        }
    }
}
