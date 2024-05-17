using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class PlayerMovement : MonoBehaviour
{
	Rigidbody m_Rigidbody;
	Animator m_Animator;
	public float rotationSpeed;
	public float minRotation;
	public float maxRotation;
	Vector3 m_EulerAngleVelocity;
	public float force;
	public bool boostAvailable = true;
	public int boostForce;

	void Start()
	{
		m_Rigidbody = GetComponent<Rigidbody>();
		m_Animator = GetComponent<Animator>();
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

		if ((angleY > minRotation) && (angleY < maxRotation))
		{
			m_Rigidbody.AddForce(transform.forward * force);
		}
		else if ((angleY <= minRotation) || (angleY >= maxRotation))
		{
			m_Rigidbody.velocity = Vector3.zero;
		}
		if (Input.GetKey(KeyCode.Space) && (boostAvailable))
		{
			m_Rigidbody.AddForce(transform.forward * boostForce);
			m_Animator.Play("Fly Forward");
			boostAvailable = false;
		}
	}
}
