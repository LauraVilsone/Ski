using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class PlayerMovement : MonoBehaviour
{
	Rigidbody m_Rigidbody;
	//public float speed = 20f;
	public float rotationSpeed;
	//public float turnSpeed = 100f;
	//public float dampen;
	public float minRotation;
	public float maxRotation;
	Vector3 m_EulerAngleVelocity;
	public float force;

	void Start()
	{
		//Fetch the Rigidbody from the GameObject with this script attached
		m_Rigidbody = GetComponent<Rigidbody>();
		m_EulerAngleVelocity = new Vector3(0, 100, 0);
	}

	void Update()
	{
		float angleY = transform.eulerAngles.y;
		if (Input.GetKey(KeyCode.A) && (angleY < maxRotation))
		{
			Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime * rotationSpeed);
			m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
		}

		if (Input.GetKey(KeyCode.D) && (angleY > minRotation))
		{
			Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime * -1 * rotationSpeed);
			m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
		}
		//if (!Input.anyKey)
		//{
		//	m_Rigidbody.AddForce(transform.forward * force);
		//}

			if ((angleY > minRotation) && (angleY < maxRotation))
			{
				m_Rigidbody.AddForce(transform.forward * force);
			}
			else if ((angleY <= minRotation) || (angleY >= maxRotation))
			{
				m_Rigidbody.velocity = Vector3.zero;
			}
	}

	//void FixedUpdate()
	//{
	//m_Rigidbody.AddForce(transform.forward * speed);

	/*if (Input.GetKey(KeyCode.A))
	{
		if(transform.rotation.eulerAngles.y < maxRotation)
		{
			transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
		}

		//m_Rigidbody.AddForce(-transform.right * turnSpeed);
		//m_Rigidbody.drag++;
		/*if (m_Rigidbody.velocity.z > 0)
		{
			m_Rigidbody.AddForce(-transform.forward * dampen);
		}*/
	//m_Rigidbody.velocity = new Vector3(turnSpeed, 0, 0);
	/*}

	if (Input.GetKey(KeyCode.D))
	{
		if (transform.rotation.eulerAngles.y > minRotation)
		{
			transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
		}*/
	//m_Rigidbody.AddForce(transform.right * turnSpeed);
	//m_Rigidbody.drag++;

	/*if(m_Rigidbody.velocity.z > 0)
	{
		m_Rigidbody.AddForce(-transform.forward * dampen);
	}*/
	//m_Rigidbody.velocity = new Vector3(-turnSpeed, 0, 0);
	//}

	//if (!Input.anyKey)
	//{
	//	m_Rigidbody.AddForce(transform.forward * speed);
	//m_Rigidbody.drag = 0;
	//}
	//}
}
