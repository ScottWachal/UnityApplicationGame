using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {
    public float tankSpeed = 25f;
	public float tankTurnSpeed = 50f;
    public Transform tankPosition;
    public Transform turretPosition;

	void Update () {
        TankMove();
	}

    private void TankMove()
    {
        float forwardMovement = Input.GetAxis("Vertical") * tankSpeed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * tankTurnSpeed * Time.deltaTime;

        tankPosition.transform.Translate(Vector3.forward * forwardMovement);
        turretPosition.transform.Rotate(Vector3.up * turnMovement);
        tankPosition.transform.Rotate(Vector3.up * turnMovement);
    }
}
