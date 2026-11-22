using UnityEngine;

public class TriggerActivate : MonoBehaviour
{
	[Header("Trigger Settings")]
	[SerializeField] private GameObject targetObject;
	[SerializeField] private string triggeringTag = "Player";

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag(triggeringTag))
		{
			if (targetObject != null)
				targetObject.SetActive(true);
		}
	}

}
