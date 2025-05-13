using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class uicontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Win, Lose, Tap, ingame;
    public bool isAdshow;


    public static uicontrol _uicontrol;
    void Awake()
    {
        _uicontrol = this;
    }
    void Start()
    {
       // GoogleAdMobController.Instance.Initialize();
        //GoogleAdMobController.Instance.RequestBannerAd();
        Tap.SetActive(true);
        isAdshow = false;
    }
    public void retryBtn_1()
    {
        //GoogleAdMobController.Instance.ShowInterstitialAd();
        Debug.Log("Рестарт сцены запускаем рекламу");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void retryBtn()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextBtn()
    {
        PlayerPrefs.SetInt("LevelNum", PlayerPrefs.GetInt("LevelNum") + 1);
        PlayerPrefs.SetInt("LevelNum_D", PlayerPrefs.GetInt("LevelNum_D") + 1);
        if (PlayerPrefs.GetInt("LevelNum") > 4)
        {
            PlayerPrefs.SetInt("LevelNum", 0);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public IEnumerator WinPanel()
    {

        yield return new WaitForSeconds(3.2f);
        uicontrol._uicontrol.Win.SetActive(true);
        yield return new WaitForSeconds(1.3f);
        Debug.Log("Мы Выйграли запускаем рекламу");
        // GoogleAdMobController.Instance.ShowInterstitialAd();

    }
    public IEnumerator LosePanel()
    {

        uicontrol._uicontrol.Lose.SetActive(true);
        yield return new WaitForSeconds(1.3f);
        Debug.Log("Мы проиграли запускаем рекламу");
       // GoogleAdMobController.Instance.ShowInterstitialAd();

    }


}
