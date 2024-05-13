using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;
    public float maxRotation;
    public float minRotation;
    public PlayerHurt playerDamage;
    private float angleY;
    private bool isGrounded;
    //private Animator animator;
    

    public float force;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
        //animator = GetComponent<Animator>();

        //Set the angular velocity of the Rigidbody (rotating around the Y axis, 100 deg/sec)
        m_EulerAngleVelocity = new Vector3(0, 100, 0);
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        angleY = transform.eulerAngles.y;
        if (Input.GetKey(KeyCode.A)&&(angleY < maxRotation)&&(playerDamage.hurt == false))
        {
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
            m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
        }

        if (Input.GetKey(KeyCode.D)&&(angleY > minRotation)&&(playerDamage.hurt == false))
        {
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime*-1);
            m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
        }

        if ((angleY > minRotation) && (angleY < maxRotation))
        {
            m_Rigidbody.AddForce(transform.forward * force);
        }
        else if ((angleY <= minRotation) || (angleY >= maxRotation))
        {
            m_Rigidbody.velocity = Vector3.zero;
        }
    }
}
