using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckCollision : MonoBehaviour
{
    private int boxLost = 0;
    private bool isTargetable;

    List<string> names = new List<string>();

    [SerializeField] GameObject explosionFX;
    GameObject explosionParticles;
    ScoreBoard sb;

    private AudioSource audioSource;

    private void Start()
    {
        sb = FindObjectOfType<ScoreBoard>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Box")
        {
            // since name is unique, I use this to set collision just once for each box
            string name = collision.collider.name;

            isTargetable = collision.collider.GetComponent<Properties>().getTargeatable();

            if (!names.Contains(name) && isTargetable)
            {
                boxLost++;
                names.Add(name);

                Vector3 colliderPosition = collision.collider.transform.position;
                explosionParticles = Instantiate(explosionFX, new Vector3(colliderPosition.x, colliderPosition.y, colliderPosition.z - 1f), Quaternion.identity);
                StartCoroutine(DestroyCube(collision.collider.gameObject, 0.3f));
                sb.DecraseOneLife();
                audioSource.Play();
            }

            if (boxLost == 3)
            {
                DontDestroyOnLoad(FindObjectOfType<GetScore>());
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    // thanks to: https://answers.unity.com/questions/897095/workaround-for-using-invoke-for-methods-with-param.html
    IEnumerator DestroyCube(GameObject cube, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Destroy(cube);
        Destroy(explosionParticles);
    }
}
