using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateAround : MonoBehaviour {

	[SerializeField] private Transform target;        // Цель слежения, зуммирования
	[SerializeField] private Vector3 offset;          // кординаты сдвигов по вектору
	[SerializeField] private float sensitivity = 1;   // чувствительность мышки
	[SerializeField] private float limit = 5;        // ограничение вращения по Y, X
	[SerializeField] private float zoom = 1f;         // чувствительность при увеличении, колесиком мышки
	[SerializeField] private float zoomMax = 18;      // макс. увеличение
	[SerializeField] private float zoomMin = 12;	  // мин. увеличение
	private float X, Y;

	void Start () 
	{
		limit = Mathf.Abs(limit);
		if(limit > 90) limit = 90;
		offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax)/2);
		transform.position = target.position + offset;
	}

	void Update ()
	{
		if(Input.GetAxis("Mouse ScrollWheel") > 0) offset.z += zoom;
		else if(Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoom;
		offset.z = Mathf.Clamp(offset.z, -Mathf.Abs(zoomMax), -Mathf.Abs(zoomMin));

		X += Input.GetAxis("Mouse X") * sensitivity;
		X = Mathf.Clamp(X, -limit, limit);
		Y += Input.GetAxis("Mouse Y") * sensitivity;
		Y = Mathf.Clamp (Y, -limit, limit);
		transform.localEulerAngles = new Vector3(-Y, X, 0);
		transform.position = transform.localRotation * offset + target.position;
	}
}