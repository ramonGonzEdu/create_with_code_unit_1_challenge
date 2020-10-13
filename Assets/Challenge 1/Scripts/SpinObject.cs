using UnityEngine;

public class SpinObject : MonoBehaviour
{
	public enum Vects
	{
		forward,
		right,
		up,
		custom,
	}


	public Vects rotationVectorChoice = Vects.forward;
	public Vector3 rotationVector = Vector3.forward;
	public float rotationSpeed = 5.0f;

	private void Start()
	{

	}

	private void Update()
	{
		switch (rotationVectorChoice)
		{
			case Vects.forward:
				transform.Rotate(Vector3.forward, rotationSpeed);
				break;
			case Vects.right:
				transform.Rotate(Vector3.right, rotationSpeed);
				break;
			case Vects.up:
				transform.Rotate(Vector3.up, rotationSpeed);
				break;
			case Vects.custom:
				transform.Rotate(rotationVector, rotationSpeed);
				break;
			default: break;
		}
	}
}