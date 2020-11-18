using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] float shootingPower = 500f;
    [SerializeField] GameObject clickFx;
    GameObject clickParticle;
    private ScoreBoard sb;

    private AudioSource audioSource;

    private void Start()
    {
        sb = FindObjectOfType<ScoreBoard>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * shootingPower);
        clickParticle = Instantiate(clickFx, transform.position, Quaternion.identity);
        sb.UpdateScore();
        gameObject.GetComponent<Properties>().setTargeatable(false);
        audioSource.Play();
        StartCoroutine(DestroyCube(gameObject, 0.3f));
    }

    IEnumerator DestroyCube(GameObject cube, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Destroy(cube);
        Destroy(clickParticle);
    }
}
