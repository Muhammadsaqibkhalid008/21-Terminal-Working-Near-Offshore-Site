using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Cam;
    public GameObject HideImage,Bucket,WaterSplash;
    public GameObject FallinWaterWithoutProtectionPanel;
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
               //CamSkipFn();
                StartCoroutine(SkipScene01());
                StopCoroutine(Scene01());
                StopCoroutine(SkipScene01());

                counter++;
            }
        }
    }
    // Update is called once per frame
    IEnumerator Scene01()
    {
        print("nonskip");

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
        //    Invoke("FadeImageOffFn", 2f);
        yield return new WaitForSeconds(4.5f);
        WaterSplash.SetActive(true);
        yield return new WaitForSeconds(2f);
        FallinWaterWithoutProtectionPanel.SetActive(true);
        StopAllCoroutines();

    }
    IEnumerator SkipScene01()
    {
        //yield return new WaitForSeconds(20f);
        //Cam[0].SetActive(false);
        print("skip");

        Cam[0].SetActive(false);
        FadeImageOnFn();
        Invoke("FadeImageOffFn", 2f);
        Cam[1].SetActive(true);
        yield return new WaitForSeconds(4f);
        FadeImageOnFn();
        Workers[0].SetActive(false);
        Workers[1].SetActive(true);
        Bucket.GetComponent<Animator>().enabled = true;
        Invoke("FadeImageOffFn", 2f);
        yield return new WaitForSeconds(4.5f);
        WaterSplash.SetActive(true);
        yield return new WaitForSeconds(2f);
        FallinWaterWithoutProtectionPanel.SetActive(true);
        StopAllCoroutines();

    }
    void FadeImageOnFn()
    {
        HideImage.SetActive(true);
    }
     void FadeImageOffFn()
    {
        HideImage.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void CamSkipFn()
    {
        StartCoroutine(SkipScene01());
    }
}
