using UnityEngine;


public class FollowTarget : MonoBehaviour
{

	
	public static GameObject target;


	private void Start()
	{

		if (target != null) return;

		target = gameObject;
		
	}


	private void Update()
	{

		if (target)
			transform.LookAt(target.transform);
	}
}
