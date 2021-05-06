using UnityEngine;

public class ColCheck : MonoBehaviour
{
	private string groundTag = "Ground";
	private void OnTriggerStay(Collider coll)
	{
		if (coll.gameObject.CompareTag(groundTag))
		{
			BuildScr.canBuild = true;
		}
		if (!coll.gameObject.CompareTag(groundTag)&&!coll.gameObject.CompareTag("Mask"))
		{
			BuildScr.canBuild = false;
		}

	}
	private void OnTriggerEnter(Collider coll)
	{
		if (coll.gameObject.CompareTag(groundTag))
		{
			BuildScr.canBuild = true;
		}
		else if (!coll.gameObject.CompareTag(groundTag))
		{
			BuildScr.canBuild = false;
		}
	}
}
