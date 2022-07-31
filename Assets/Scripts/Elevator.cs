using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
	[SerializeField] Vector3 startingPoint;
	[SerializeField] Vector3 endingPoint;
	[SerializeField] float speed;

	private Transform _transform;
	// Start is called before the first frame update
	void Awake()
	{
		_transform = this.transform;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		_transform.position = Vector3.Lerp(startingPoint, endingPoint, Mathf.PingPong(Time.time * speed, 1));
	}
}
