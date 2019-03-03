using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {

    [SerializeField] float loadingBallTime = 2;
    [SerializeField] float kickBallForce = 10000;

    [Space]

    [SerializeField] GameObject floorSectionPipe; 
    Animator animator;

    private void Awake()
    {
        animator = transform.GetComponentInChildren<Animator>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Ball")) return;

        StartCoroutine(Actived(other.transform));
    }

    IEnumerator Actived (Transform ball)
    {
        animator.SetBool("Ball in the pipe", true);
        ball.position = transform.position + new Vector3(0.03f, 0, 0);
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        ballRigidbody.constraints = RigidbodyConstraints.FreezePosition;
        LightingFloor lightingFloor = floorSectionPipe.GetComponent<LightingFloor>();
        lightingFloor.LightUp(); 

        yield return new WaitForSeconds(loadingBallTime);

        ballRigidbody.constraints = RigidbodyConstraints.None;
        ballRigidbody.AddForce(transform.up * Random.Range( kickBallForce * 0.9f, kickBallForce * 1.1f ), ForceMode.Impulse); 
        animator.SetBool("Ball in the pipe", false);
        lightingFloor.TurnOffTheLight(); 

        yield break; 
    }
}
