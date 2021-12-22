using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float ForwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
       
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    bool triggeredLeft;
    bool triggeredRight
        ;
    public void pointerLeftUp()
    {
        triggeredLeft = false;
    }

    public void pointerLeftDown()
    {
        triggeredLeft = true;
    }

    public void pointerRighttUp()
    {
        triggeredRight = false;
    }

    public void pointerRightDown()
    {
        triggeredRight = true;
    }

    void Update()
    {
        if (triggeredLeft)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (triggeredRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
