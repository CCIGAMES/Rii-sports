using UnityEngine;

public class Looker : MonoBehaviour
{
    public GameObject ai;
    private float reset = 5;
    private bool movingDown;

    private void Start()
    {
        if (movingDown == false)
            transform.position -= new Vector3(0, 0, 0.1f);
        else
            transform.position += new Vector3(0, 0, 0.1f);
        if (transform.position.z > 10)
            movingDown = false;
        else if (transform.position.z < -10)
            movingDown = true;
        reset -= Time.deltaTime;
        if (reset < 0)
        {
            ai.GetComponent<AI>().enabled = false;
            GetComponent<BoxCollider>().enabled = true;
        }
    }

    public void Update()
    {
        if (movingDown == false)
        {
            transform.position -= new Vector3(0, 0, 0.1f);
        }else
        { 
            transform.position += new Vector3(0, 0, 0.1f);
        }

        if (transform.position.z > 10)
        {
            movingDown = false;
        }else if (transform.position.z < 10)
        {
            movingDown = true;
        }

        reset -= Time.deltaTime;
        if (reset < 0)
        {
            ai.GetComponent<AI>().enabled = true;
            GetComponent<BoxCollider>().enabled = false;
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ai.GetComponent<AI>().enabled = true;
            reset = 5;
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
