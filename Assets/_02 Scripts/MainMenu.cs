using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainPanel, LoadingPanel;
    [Header("Scenario 01")]
    public GameObject  ScenarioPanel01;
    public GameObject  FallingFromWaterPanel;
    public GameObject  FallingFromHeightPanel;
    [Header("Scenario 02")]
    public GameObject ScenarioPanel02;
    public GameObject FallingObj;
    public GameObject DamageEquipment;
    public GameObject OffShoreSpill;

    void Start()
    {

    }

    public void Btn01Fn()
    {
        MainPanel.SetActive(false);
        ScenarioPanel01.SetActive(true);
    }
    public void Btn01BackFn()
    {
        MainPanel.SetActive(true);
        ScenarioPanel01.SetActive(false);
    }
    public void Btn02Fn()
    {
        MainPanel.SetActive(false);
        ScenarioPanel02.SetActive(true);
    }
    public void Btn02BackFn()
    {
        MainPanel.SetActive(true);
        ScenarioPanel02.SetActive(false);
    }
    /// <summary>
    /// Falling From Height Scenario Start
    /// </summary>
    public void FallingfromWaterFn()
    {
        ScenarioPanel01.SetActive(false);
        FallingFromWaterPanel.SetActive(true);
    }
    public void FallingfromWaterBackFn()
    {
        ScenarioPanel01.SetActive(true);
        FallingFromWaterPanel.SetActive(false);
    }
    public void FallFromWaterWithPEF()
    {
        FallingFromWaterPanel.SetActive(false);
        LoadingFn();
        Invoke("Scene02Load", 2f);
    }
    public void FallFromWaterWithOutPEF()
    {
        FallingFromWaterPanel.SetActive(false);
        LoadingFn();
       Invoke("Scene01Load", 2f);
    }
   
    /// <summary>
    /// Falling From Height Scenario End
    /// </summary>
    public void FallingfromHeightFn()
    {
        ScenarioPanel01.SetActive(false);
        FallingFromHeightPanel.SetActive(true);
    }
    public void FallingfromHeightBackFn()
    {
        ScenarioPanel01.SetActive(true);
        FallingFromHeightPanel.SetActive(false);
    }
    public void FallFromHeightWithOutSafetyHarness()
    {
        FallingFromHeightPanel.SetActive(false);
        LoadingFn();
        Invoke("Scene03Load", 2f);
    }
    public void FallFromHeightWitSafetyHarness()
    {
        FallingFromHeightPanel.SetActive(false);
        LoadingFn();
        Invoke("Scene04Load", 2f);
    }
    public void FallingObjFn()
    {
        ScenarioPanel02.SetActive(false);
        FallingObj.SetActive(true);
    }
    public void FallingObjWithLiftPlanFn()
    {
        FallingObj.SetActive(false);
        LoadingFn();
        Invoke("Scene05Load", 2f);
    }
    public void FallingObjWithoutLiftPlanFn()
    {
        FallingObj.SetActive(false);
        LoadingFn();
        Invoke("Scene06Load", 2f);
    }
    public void FallingObjBackFn()
    {
        ScenarioPanel02.SetActive(true);
        FallingObj.SetActive(false);
    }
    public void DamageEquipmentFn()
    {
        ScenarioPanel02.SetActive(false);
        DamageEquipment.SetActive(true);
    }
    public void DamageEquipmentFnWithLiftPlan()
    {
        DamageEquipment.SetActive(false);
        LoadingFn();
        Invoke("Scene07Load", 2f);
    }
    public void DamageEquipmentFnWithOutLiftPlan()
    {
        DamageEquipment.SetActive(false);
        LoadingFn();
        Invoke("Scene08Load", 2f);
    }
    public void DamageEquipmentBackFn()
    {
        ScenarioPanel02.SetActive(true);
        DamageEquipment.SetActive(false);
    }
    public void OffShoreSpillFn()
    {
        ScenarioPanel02.SetActive(false);
        OffShoreSpill.SetActive(true);
    }
    public void OffShoreSpillBackFn()
    {
        ScenarioPanel02.SetActive(true);
        OffShoreSpill.SetActive(false);
    }

    public void LoadingFn()
    {
        LoadingPanel.SetActive(true);
    }
    public void Scene01Load()
    {
        SceneManager.LoadScene(1);
    }
    public void Scene02Load()
    {
        SceneManager.LoadScene(2);
    }
    public void Scene03Load()
    {
        SceneManager.LoadScene(3);
    }
    public void Scene04Load()
    {
        SceneManager.LoadScene(4);
    }
    public void Scene05Load()
    {
        SceneManager.LoadScene(5);
    }
    public void Scene06Load()
    {
        SceneManager.LoadScene(6);
    }
    public void Scene07Load()
    {
        SceneManager.LoadScene(7);
    }
    public void Scene08Load()
    {
        SceneManager.LoadScene(8);
    }
    public void Exit()
    {
        Application.Quit();
    }

}
