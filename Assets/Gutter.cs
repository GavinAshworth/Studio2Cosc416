using UnityEngine;

public class Gutter : MonoBehaviour
{
   private void OnTriggerEnter(Collider triggeredBody){
    Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();
    float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

    ballRigidBody.linearVelocity = Vector3.zero;
    ballRigidBody.angularVelocity = Vector3.zero;

    //The directionality of transform.forward was not working. So I instead used this
    ballRigidBody.AddForce(Vector3.forward * velocityMagnitude, ForceMode.VelocityChange);
   }
}
