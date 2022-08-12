using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager8 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Cam;
    public GameObject HideImage;
    public GameObject TypesofRopesPanel,CompletePanel;
    public GameObject[] Workers;
    public GameObject Ship;
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
        FadeImageOnFn();
        Invoke("FadeImageOffFn", 2f);
        Workers[0].GetComponent<Animator>().enabled = true;
        Workers[1].GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(2f);
        Ship.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(15.1f);
        Workers[0].GetComponent<Animator>().enabled = false;
        Workers[1].GetComponent<Animator>().enabled = false;
        Ship.GetComponent<Animator>().enabled = false;
        CompletePanel.SetActive(true);


        StopAllCoroutines();

    }
    IEnumerator SkipScene01()
    {
        //  yield return new WaitForSeconds(20f);
        Cam[0].SetActive(false);
        FadeImageOnFn();
        Invoke("FadeImageOffFn", 2f);
        Cam[1].SetActive(true);
        yield return new WaitForSeconds(0f);
        FadeImageOnFn();
        Invoke("FadeImageOffFn", 2f);
        Workers[0].GetComponent<Animator>().enabled = true;
        Workers[1].GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(2f);
        Ship.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(15.1f);
        Workers[0].GetComponent<Animator>().enabled = false;
        Workers[1].GetComponent<Animator>().enabled = false;
        Ship.GetComponent<Animator>().enabled = false;
        CompletePanel.SetActive(true);



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
