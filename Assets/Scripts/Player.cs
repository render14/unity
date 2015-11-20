using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Rigidbody myRigidbody;
    public float mySpeed;
	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        float myHorizontalMove = Input.GetAxis("Horizontal");
        Vector3 myMovement = new Vector3(myHorizontalMove, 0, 0);
        
        myRigidbody.AddForce(myMovement*mySpeed);

        float myVerticalMove = Input.GetAxis("Vertical");
        Vector3 myMovement2 = new Vector3(0, 0, myVerticalMove);

        myRigidbody.AddForce(myMovement2 * mySpeed);
    }
}
