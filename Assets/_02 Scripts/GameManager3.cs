using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Cam;
    public GameObject HideImage, Bucket, BloodParticles;
    public GameObject FallFromHeightWithtSafetyBelt;
    public GameObject[] Workers;
    int counter = 0;

    void Start()
    {
        StartCoroutine(Scene01());
    }
    private void Update()
    {
        if (counter == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("keypressed");
                StartCoroutine(SkipScene01());
                StopCoroutine(Scene01());
                StopCoroutine(SkipScene01());
                counter++;
                print(counter);
            }
        }
    }
    // Update is called once per frame
    IEnumerator Scene01()
    {
        yield return new WaitForSeconds(20f);
        Cam[0].SetActive(false);
        FadeImageOnFn();
        Invoke("FadeImageOffFn", 2f);
        Cam[1].SetActive(true);
        yield return new WaitForSeconds(4f);
        FadeImageOnFn();
        Invoke("FadeImageOffFn", 2f);
        Workers[0].SetActive(false);
        Workers[1].SetActive(true);
        Bucket.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(5f);
        FadeImageOnFn();
        Invoke("FadeImageOffFn", 2f);
        Workers[1].SetActive(false);
        Workers[2].SetActive(true);
        yield return new WaitForSeconds(3f);
        FallFromHeightWithtSafetyBelt.SetActive(true);
        StopAllCoroutines();

    }
    IEnumerator SkipScene01()
    {
       // yield return new WaitForSeconds(20f);
        Cam[0].SetActive(false);
        FadeImageOnFn();
        Invoke("FadeImageOffFn", 2f);
        Cam[1].SetActive(true);
        yield return new WaitForSeconds(4f);
        FadeImageOnFn();
        Invoke("FadeImageOffFn", 2f);
        Workers[0].SetActive(false);
        Workers[1].SetActive(true);
        Bucket.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(5f);
        FadeImageOnFn();
        Invoke("FadeImageOffFn", 2f);
        Workers[1].SetActive(false);
        Workers[2].SetActive(true);
        yield return new WaitForSeconds(3f);
        FallFromHeightWithtSafetyBelt.SetActive(true);
        StopAllCoroutines();

    }
    public void FadeImageOnFn()
    {
        HideImage.SetActive(true);
    }
    public void FadeImageOffFn()
    {
        HideImage.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
