using UnityEngine;
using System.Collections;

enum UI_STATE{
	INTRO,
	STORE,
	PLAY,
	RESULT
}
public class GameManager : MonoBehaviour {
	private static GameManager s_instance;

	#region Public Properties
	
	public static GameManager Instance
	{
		get
		{
			return s_instance;
		}
	}
	#endregion
	
	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
		s_instance = this;
	}
	
	private void OnDestroy()
	{
		s_instance = null;
	}
	


	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			print ("NExt");
			Application.LoadLevel(1);
				}
	}
}
