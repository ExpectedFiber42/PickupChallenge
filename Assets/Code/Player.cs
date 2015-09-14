using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float m_score = 0;
    public bool slowOne = false;
    public bool slowTwo = false;
    public float playerSpeed = 50;

    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += Vector3.right / playerSpeed;

        if (m_score == 2)
        {
            if (!slowOne)
            {
                slowOne = true;
                Debug.Log("Slower Movement Initiated");
                playerSpeed = 100;
            }
        }

        if(m_score == 3)
        { 

                this.transform.Rotate(new Vector3(0,0,5));
            
        }
    }
}
