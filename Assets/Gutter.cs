using UnityEngine;

public class Gutter : MonoBehaviour
{
   private void OnTriggerEnter(Collider triggeredBody){
    // Check if the object has the "Ball" tag(added this check to stop pins from triggering this)
    if (!triggeredBody.CompareTag("Ball")) return;
    Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();
    //This check stops the code from trying to change the velocity of the ball when it is still in the players hands, happens sometimes when the ball gets too close to the gutter while in the hands of the player
    if(ballRigidBody.isKinematic){
        return;
    }
    float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

    ballRigidBody.linearVelocity = Vector3.zero;
    ballRigidBody.angularVelocity = Vector3.zero;

    //The directionality of transform.forward was not working. So I instead used this
    ballRigidBody.AddForce(Vector3.forward * velocityMagnitude, ForceMode.VelocityChange);
   }
}
