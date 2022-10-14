using UnityEngine;

public class Rotate : MonoBehaviour
{
	private void Start() { // I added this part from https://docs.unity3d.com/ScriptReference/Cursor-lockState.html
		Cursor.lockState = CursorLockMode.Locked; 
	}
    // sc: https://gist.github.com/KarlRamstedt/407d50725c7b6abeaf43aee802fdd88e
	public float Sensitivity {
		get { return sensitivity; }
		set { sensitivity = value; }
	}
	[Range(0.1f, 9f)][SerializeField] float sensitivity = 2f;
	[Tooltip("Limits vertical camera rotation. Prevents the flipping that happens when rotation goes above 90.")]
	[Range(0f, 90f)][SerializeField] float yRotationLimit = 88f;

	Vector2 rot = Vector2.zero;
	const string xAxis = "Mouse X"; //Strings in direct code generate garbage, storing and re-using them creates no garbage
	const string yAxis = "Mouse Y";

	void Update(){
		rot.x += Input.GetAxis(xAxis) * sensitivity;
		rot.y += Input.GetAxis(yAxis) * sensitivity;
		rot.y = Mathf.Clamp(rot.y, -yRotationLimit, yRotationLimit);
		var xQuat = Quaternion.AngleAxis(rot.x, Vector3.up);
		var yQuat = Quaternion.AngleAxis(rot.y, Vector3.left);

		transform.localRotation = xQuat * yQuat; //Quaternions seem to rotate more consistently than EulerAngles. Sensitivity seemed to change slightly at certain degrees using Euler. transform.localEulerAngles = new Vector3(-rotation.y, rotation.x, 0);
	}
}
