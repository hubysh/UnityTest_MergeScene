using UnityEngine;
using System.Collections;

public class UIMgr : MonoBehaviour
{
	public void OnClickStartBtn()
	{
		Debug.Log("Click Button");
		Application.LoadLevel("scnSphere");
		Application.LoadLevelAdditive("scnCylinder");
	
	}
}
