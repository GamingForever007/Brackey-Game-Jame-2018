//A script that moves the player
//Author: Aleksander Kovač & S4NNY1

using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {

    private Rigidbody rigidbody;

    //variables that are goint to be updated 
    [SerializeField]
    private int maxJumps = 1;

    [SerializeField]
    private int jumpForce = 200;

	void Start () {

        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space) && maxJumps > 0)
        {
            maxJumps--;
            rigidbody.velocity = new Vector3(0, jumpForce * Time.deltaTime, 0);
        }
	}
}
