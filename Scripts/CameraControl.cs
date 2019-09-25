﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;
using UnityEngine.Audio;

public class CameraControl : MonoBehaviour
{

    static bool _AdsIs = false;

    static int LevelScoreLabel;

    public GameObject Settings;

    public GameObject Toggle_Music;
    public GameObject Toggle_Sounds;

    public AudioMixerGroup SoundTreckMixer;
    public AudioMixerGroup Sounds;

    public AudioClip ButtonSoundOpen;
    public AudioClip ButtonSoundClose;

    public AudioClip start_sound;

    [SerializeField] private GameObject levels;
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject Win_Menu;
    [SerializeField] private GameObject level_2_WB;
    [SerializeField] private GameObject level_3_WB;
    [SerializeField] private GameObject level_4_WB;
    [SerializeField] private GameObject level_5_WB;
    [SerializeField] private GameObject level_6_WB;
    [SerializeField] private GameObject level_7_WB;
    [SerializeField] private GameObject level_8_WB;
    [SerializeField] private GameObject level_9_WB;
    [SerializeField] private GameObject level_10_WB;

    [SerializeField] private GameObject Exit_from_Menu;

    [SerializeField] private Transform Chicken_0;
    [SerializeField] private Transform Chicken_1;
    [SerializeField] private Transform Chicken_2;
    [SerializeField] private Transform Chicken_3;
    [SerializeField] private Transform Chicken_4;
    [SerializeField] private Transform Chicken_5;
    [SerializeField] private Transform Chicken_6;
    [SerializeField] private Transform Chicken_7;
    [SerializeField] private Transform Chicken_8;
    [SerializeField] private Transform Chicken_9;
    [SerializeField] private Transform Chicken_10;
    [SerializeField] private Transform Chicken_11;
    [SerializeField] private Transform Chicken_12;

    [SerializeField] private GameObject Skins;
    [SerializeField] private GameObject exit;
    [SerializeField] private GameObject Skins_Image_1;
    [SerializeField] private GameObject Skins_Image_2;
    [SerializeField] private GameObject Skins_Image_3;
    [SerializeField] private GameObject Skins_Image_4;
    [SerializeField] private GameObject Skins_Image_5;
    [SerializeField] private GameObject Skins_Image_6;
    [SerializeField] private GameObject Skins_Image_7;
    [SerializeField] private GameObject Skins_Image_8;
    [SerializeField] private GameObject Skins_Image_9;
    [SerializeField] private GameObject Skins_Image_10;
    [SerializeField] private GameObject Skins_Image_11;
    [SerializeField] private GameObject Skins_Image_12;
    [SerializeField] private GameObject Skins_Image_13;

    [SerializeField] private GameObject skins_WB_2;
    [SerializeField] private GameObject skins_WB_4;
    [SerializeField] private GameObject skins_WB_5;
    [SerializeField] private GameObject skins_WB_6;
    [SerializeField] private GameObject skins_WB_7;
    [SerializeField] private GameObject skins_WB_8;
    [SerializeField] private GameObject skins_WB_9;

    [SerializeField] private GameObject Skins_Button_1;
    [SerializeField] private GameObject Skins_Button_2;
    [SerializeField] private GameObject Skins_Button_3;
    [SerializeField] private GameObject Skins_Button_4;
    [SerializeField] private GameObject Skins_Button_5;
    [SerializeField] private GameObject Skins_Button_6;
    [SerializeField] private GameObject Skins_Button_7;
    [SerializeField] private GameObject Skins_Button_8;
    [SerializeField] private GameObject Skins_Button_9;
    [SerializeField] private GameObject Skins_Button_10;
    [SerializeField] private GameObject Skins_Button_11;
    [SerializeField] private GameObject Skins_Button_12;
    [SerializeField] private GameObject Skins_Button_13;

    [SerializeField] private GameObject Ads_1;
    [SerializeField] private GameObject Ads_4;
    [SerializeField] private GameObject Ads_6;
    [SerializeField] private GameObject Ads_9;
    [SerializeField] private GameObject Ads_11;

    [SerializeField] private GameObject Ok_1;
    [SerializeField] private GameObject Ok_2;
    [SerializeField] private GameObject Ok_3;
    [SerializeField] private GameObject Ok_4;
    [SerializeField] private GameObject Ok_5;
    [SerializeField] private GameObject Ok_6;
    [SerializeField] private GameObject Ok_7;
    [SerializeField] private GameObject Ok_8;
    [SerializeField] private GameObject Ok_9;
    [SerializeField] private GameObject Ok_10;
    [SerializeField] private GameObject Ok_11;
    [SerializeField] private GameObject Ok_12;
    [SerializeField] private GameObject Ok_13;

    [SerializeField] private AudioClip ChangeChickenClip;
    [SerializeField] private AudioClip ChangeLanguageClip;
    [SerializeField] private AudioClip ToggleChangeClip;

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    private void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(start_sound);
        if (PlayerPrefs.GetInt("SoundTreckVolume") == -80)
        {
            Toggle_Music.SetActive(false);
            SoundTreckMixer.audioMixer.SetFloat("SoundTreckVolume", -80);
        }
        else
        {
            SoundTreckMixer.audioMixer.SetFloat("SoundTreckVolume", 0);
        }

        if (PlayerPrefs.GetInt("SoundsVolume") == -80)
        {
            Toggle_Sounds.SetActive(false);
        }
        Settings.gameObject.SetActive(false);
        Exit_from_Menu.SetActive(false);
        Skins.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);

        if (PlayerPrefs.GetInt("ChickenIndex") == 0)
        {
            Instantiate(Chicken_0, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 1)
        {
            Instantiate(Chicken_1, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 2)
        {
            Instantiate(Chicken_2, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 3)
        {
            Instantiate(Chicken_3, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 4)
        {
            Instantiate(Chicken_4, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 5)
        {
            Instantiate(Chicken_5, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 6)
        {
            Instantiate(Chicken_6, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 7)
        {
            Instantiate(Chicken_7, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 8)
        {
            Instantiate(Chicken_8, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 9)
        {
            Instantiate(Chicken_9, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 10)
        {
            Instantiate(Chicken_10, Chicken_0.transform.position, Chicken_0.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 11)
        {
            Instantiate(Chicken_11, Chicken_11.transform.position, Chicken_11.rotation);
        }

        if (PlayerPrefs.GetInt("ChickenIndex") == 12)
        {
            Instantiate(Chicken_12, Chicken_0.transform.position, Chicken_0.rotation);
        }

        levels.gameObject.SetActive(false);
        LevelScoreLabel = PlayerPrefs.GetInt("SkinsScore");
        if (LevelScoreLabel == 0)
        {
            PlayerPrefs.SetInt("IsButton_1_Active", 1); // 0 - активен  1 - неактивен
            PlayerPrefs.SetInt("IsButton_2_Active", 0);
            PlayerPrefs.SetInt("IsButton_3_Active", 0);
            PlayerPrefs.SetInt("IsButton_4_Active", 0);
            PlayerPrefs.SetInt("IsButton_5_Active", 0);
            PlayerPrefs.SetInt("IsButton_6_Active", 0);
            PlayerPrefs.SetInt("IsButton_7_Active", 0);
            PlayerPrefs.SetInt("IsButton_8_Active", 0);
            PlayerPrefs.SetInt("IsButton_9_Active", 0);
            PlayerPrefs.SetInt("IsButton_10_Active", 0);
            PlayerPrefs.SetInt("IsButton_11_Active", 0);
            PlayerPrefs.SetInt("IsButton_12_Active", 0);
            PlayerPrefs.SetInt("IsButton_13_Active", 0);

            PlayerPrefs.SetInt("IsButtonHave_2_ADS_", 0);
            PlayerPrefs.SetInt("IsButtonHave_4_ADS_", 0);
            PlayerPrefs.SetInt("IsButtonHave_6_ADS_", 0);
            PlayerPrefs.SetInt("IsButtonHave_9_ADS_", 0);
            PlayerPrefs.SetInt("IsButtonHave_11_ADS_", 0);

        }
        if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
        {
            Skins_Button_2.SetActive(false);
            Ads_1.SetActive(true);
        }
        else { Ads_1.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
        {
            Skins_Button_4.SetActive(false);
            Ads_4.SetActive(true);
        }
        else { Ads_4.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
        {
            Skins_Button_6.SetActive(false);
            Ads_6.SetActive(true);
        }
        else { Ads_6.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
        {
            Skins_Button_9.SetActive(false);
            Ads_9.SetActive(true);
        }
        else { Ads_9.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
        {
            Skins_Button_11.SetActive(false);
            Ads_11.SetActive(true);
        }
        else { Ads_11.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_1_Active") == 1)
        {
            Skins_Button_1.gameObject.SetActive(false);
            Ok_1.SetActive(true);
        }
        else { Ok_1.SetActive(false); }

        if (PlayerPrefs.GetInt("IsButton_2_Active") == 1)
        {
            Skins_Button_2.SetActive(false);
            Ads_1.SetActive(false);
            Ok_2.SetActive(true);
        }
        else { Ok_2.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_3_Active") == 1)
        {
            Skins_Button_3.SetActive(false);
            Ok_3.SetActive(true);
        }
        else { Ok_3.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_4_Active") == 1)
        {
            Skins_Button_4.SetActive(false);
            Ads_4.SetActive(false);
            Ok_4.SetActive(true);
        }
        else { Ok_4.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_5_Active") == 1)
        {
            Skins_Button_5.SetActive(false);
            Ok_5.SetActive(true);
        }
        else { Ok_5.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_6_Active") == 1)
        {
            Skins_Button_6.SetActive(false);
            Ads_6.SetActive(false);
            Ok_6.SetActive(true);
        }
        else { Ok_6.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_7_Active") == 1)
        {
            Skins_Button_7.SetActive(false);
            Ok_7.SetActive(true);
        }
        else { Ok_7.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_8_Active") == 1)
        {
            Skins_Button_8.SetActive(false);
            Ok_8.SetActive(true);
        }
        else { Ok_8.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_9_Active") == 1)
        {
            Skins_Button_9.SetActive(false);
            Ads_9.SetActive(false);
            Ok_9.SetActive(true);
        }
        else { Ok_9.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_10_Active") == 1)
        {
            Skins_Button_10.SetActive(false);
            Ok_10.SetActive(true);
        }
        else { Ok_10.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_11_Active") == 1)
        {
            Skins_Button_11.SetActive(false);
            Ads_11.SetActive(false);
            Ok_11.SetActive(true);
        }
        else { Ok_11.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_12_Active") == 1)
        {
            Skins_Button_12.SetActive(false);
            Ok_12.SetActive(true);
        }
        else { Ok_12.SetActive(false); }
        if (PlayerPrefs.GetInt("IsButton_13_Active") == 1)
        {
            Skins_Button_13.SetActive(false);
            Ok_13.SetActive(true);
        }

        else { Ok_13.SetActive(false); }
        if (PlayerPrefs.GetString("Level-3_Open/Closed") == "open")
        {
            level_3_WB.gameObject.SetActive(false);
            skins_WB_2.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetString("Level-2_Open/Closed") == "open")
        {
            level_2_WB.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetString("Level-4_Open/Closed") == "open")
        {
            level_4_WB.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetString("Level-5_Open/Closed") == "open")
        {
            level_5_WB.gameObject.SetActive(false);
            skins_WB_4.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level-6_Open/Closed") == "open")
        {
            level_6_WB.gameObject.SetActive(false);
            skins_WB_5.gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetString("Level-7_Open/Closed") == "open")
        {
            level_7_WB.gameObject.SetActive(false);
            skins_WB_6.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level-8_Open/Closed") == "open")
        {
            level_8_WB.gameObject.SetActive(false);
            skins_WB_7.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level-9_Open/Closed") == "open")
        {
            level_9_WB.gameObject.SetActive(false);
            skins_WB_8.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetString("Level-10_Open/Closed") == "open")
        {
            level_10_WB.gameObject.SetActive(false);
            skins_WB_9.gameObject.SetActive(false);
        }
    }

    public void Levels()
    {
        Exit_from_Menu.SetActive(false);
        if (Win_Menu.activeSelf)
        {
            Win_Menu.SetActive(false);
            PlayerPrefs.SetInt("InputMenu", 1);
        }
        if (Menu.activeSelf)
        {
            Menu.SetActive(false);
            PlayerPrefs.SetInt("InputMenu", 0);
        }
        levels.gameObject.SetActive(true);
    }

    public void LoadScene_1()
    {
        SceneManager.LoadScene("Level-1");
    }

    public void LoadScene_2()
    {
        SceneManager.LoadScene("Level-2");
    }

    public void LoadScene_3()
    {
        SceneManager.LoadScene("Level-3");
    }

    public void LoadScene_4()
    {
        SceneManager.LoadScene("Level-4");
    }

    public void LoadScene_5()
    {
        SceneManager.LoadScene("Level-5");
    }

    public void LoadScene_6()
    {
        SceneManager.LoadScene("Level-6");
    }

    public void LoadScene_7()
    {
        SceneManager.LoadScene("Level-7");
    }

    public void LoadScene_8()
    {
        SceneManager.LoadScene("Level-8");
    }

    public void LoadScene_9()
    {
        SceneManager.LoadScene("Level-9");
    }

    public void LoadScene_10()
    {
        SceneManager.LoadScene("Level-10");
    }

    public void Exit()
    {
        levels.gameObject.SetActive(false);
        if(PlayerPrefs.GetInt("InputMenu") == 1)
        {
            Win_Menu.gameObject.SetActive(true);
        }
        else
        {
            Menu.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("IsDied") == 0)
            {
                Exit_from_Menu.SetActive(true);
            }
        }
    }

    public void Next_Level()
    {
        string nowScene = SceneManager.GetActiveScene().name;
        if (nowScene == "Level-1")
        {
            SceneManager.LoadScene("Level-2");

        }
        if (nowScene == "Level-2")
        {
            SceneManager.LoadScene("Level-3");

        }
        if (nowScene == "Level-3")
        {
            SceneManager.LoadScene("Level-4");

        }
        if (nowScene == "Level-4")
        {
            SceneManager.LoadScene("Level-5");

        }
        if (nowScene == "Level-5")
        {
            SceneManager.LoadScene("Level-6");
        }
        if (nowScene == "Level-6")
        {
            SceneManager.LoadScene("Level-7");
        }
        if (nowScene == "Level-7")
        {
            SceneManager.LoadScene("Level-8");
        }
        if (nowScene == "Level-8")
        {
            SceneManager.LoadScene("Level-9");
        }
        if (nowScene == "Level-9")
        {
            SceneManager.LoadScene("Level-10");
        }

    }

    public void SkinsOpen()
    {
        if (Monetization.isSupported)
        {
            Monetization.Initialize("3272263", false);
        }
        Exit_from_Menu.SetActive(false);
        Skins_Image_1.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_2.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_3.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_4.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_5.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_6.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_7.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_8.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_9.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_10.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_11.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_12.gameObject.transform.localScale = new Vector3(1, 1, 1);
        Skins_Image_13.gameObject.transform.localScale = new Vector3(1, 1, 1);
        if (Win_Menu.activeSelf)
        {
            Win_Menu.SetActive(false);
            PlayerPrefs.SetInt("InputMenu", 1);
        }
        if (Menu.activeSelf)
        {
            Menu.SetActive(false);
            PlayerPrefs.SetInt("InputMenu", 0);
        }
        Menu.gameObject.SetActive(false);
        Skins.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
    }

    public void ExitSkins()
    {
        Skins.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("InputMenu") == 1)
        {
            Win_Menu.gameObject.SetActive(true);
        }
        else
        {
            Menu.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("IsDied") == 0)
            {
                Exit_from_Menu.SetActive(true);
            }
        }
    }


    public void Stop()
    {
        Exit_from_Menu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ChangeToChicken_0()
    {
        GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
        PlayerPrefs.SetInt("IsButton_1_Active", 1);
        PlayerPrefs.SetInt("IsButton_2_Active", 0);
        PlayerPrefs.SetInt("IsButton_3_Active", 0);
        PlayerPrefs.SetInt("IsButton_4_Active", 0);
        PlayerPrefs.SetInt("IsButton_5_Active", 0);
        PlayerPrefs.SetInt("IsButton_6_Active", 0);
        PlayerPrefs.SetInt("IsButton_7_Active", 0);
        PlayerPrefs.SetInt("IsButton_8_Active", 0);
        PlayerPrefs.SetInt("IsButton_9_Active", 0);
        PlayerPrefs.SetInt("IsButton_10_Active", 0);
        PlayerPrefs.SetInt("IsButton_11_Active", 0);
        PlayerPrefs.SetInt("IsButton_12_Active", 0);
        PlayerPrefs.SetInt("IsButton_13_Active", 0);
        PlayerPrefs.SetInt("ChickenIndex", 0);
        Skins_Button_3.SetActive(true);
        Ok_2.SetActive(false);
        Ok_3.SetActive(false);
        Ok_4.SetActive(false);
        Ok_5.SetActive(false);
        Ok_6.SetActive(false);
        Ok_7.SetActive(false);
        Ok_8.SetActive(false);
        Ok_9.SetActive(false);
        Ok_10.SetActive(false);
        Ok_11.SetActive(false);
        Ok_12.SetActive(false);
        Ok_13.SetActive(false);
        Skins_Button_3.SetActive(true);
        Skins_Button_5.SetActive(true);
        Skins_Button_7.SetActive(true);
        Skins_Button_8.SetActive(true);
        Skins_Button_10.SetActive(true);
        Skins_Button_12.SetActive(true);
        Skins_Button_13.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
        {
            Skins_Button_2.SetActive(false);
            Ads_1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
        {
            Skins_Button_4.SetActive(false);
            Ads_4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
        {
            Skins_Button_6.SetActive(false);
            Ads_6.SetActive(true);
        }
        if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
        {
            Skins_Button_9.SetActive(false);
            Ads_9.SetActive(true);
        }
        if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
        {
            Skins_Button_11.SetActive(false);
            Ads_11.SetActive(true);
        }
        Skins_Button_1.SetActive(false);
        Ok_1.SetActive(true);
        LevelScoreLabel++;
        PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
    }

    public void ChangeToChicken_1()
    {
        if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
            PlayerPrefs.SetInt("IsButton_1_Active", 0);
            PlayerPrefs.SetInt("IsButton_2_Active", 1);
            PlayerPrefs.SetInt("IsButton_3_Active", 0);
            PlayerPrefs.SetInt("IsButton_4_Active", 0);
            PlayerPrefs.SetInt("IsButton_5_Active", 0);
            PlayerPrefs.SetInt("IsButton_6_Active", 0);
            PlayerPrefs.SetInt("IsButton_7_Active", 0);
            PlayerPrefs.SetInt("IsButton_8_Active", 0);
            PlayerPrefs.SetInt("IsButton_9_Active", 0);
            PlayerPrefs.SetInt("IsButton_10_Active", 0);
            PlayerPrefs.SetInt("IsButton_11_Active", 0);
            PlayerPrefs.SetInt("IsButton_12_Active", 0);
            PlayerPrefs.SetInt("IsButton_13_Active", 0);
            PlayerPrefs.SetInt("ChickenIndex", 1);

            Ok_1.SetActive(false);
            Ok_3.SetActive(false);
            Ok_4.SetActive(false);
            Ok_5.SetActive(false);
            Ok_6.SetActive(false);
            Ok_7.SetActive(false);
            Ok_8.SetActive(false);
            Ok_9.SetActive(false);
            Ok_10.SetActive(false);
            Ok_11.SetActive(false);
            Ok_12.SetActive(false);
            Ok_13.SetActive(false);
            Skins_Button_1.SetActive(true);
            Skins_Button_3.SetActive(true);
            Skins_Button_5.SetActive(true);
            Skins_Button_7.SetActive(true);
            Skins_Button_8.SetActive(true);
            Skins_Button_10.SetActive(true);
            Skins_Button_12.SetActive(true);
            Skins_Button_13.SetActive(true);

            if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
            {
                Skins_Button_4.SetActive(false);
                Ads_4.SetActive(true);
            }
            if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
            {
                Skins_Button_6.SetActive(false);
                Ads_6.SetActive(true);
            }
            if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
            {
                Skins_Button_9.SetActive(false);
                Ads_9.SetActive(true);
            }
            if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
            {
                Skins_Button_11.SetActive(false);
                Ads_11.SetActive(true);
            }

            Ads_1.SetActive(false);
            Ok_2.SetActive(true);
            LevelScoreLabel++;
            Skins_Button_2.SetActive(false);
            PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);

        }
        else
        {
            if (Monetization.IsReady("rewardedVideo"))
            {
                ShowAdCallbacks options = new ShowAdCallbacks();
                options.finishCallback = HandleShowResult;
                ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
                ad.Show(options);
            }
            if (_AdsIs == true)
            {
                GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
                PlayerPrefs.SetInt("IsButton_1_Active", 0);
                PlayerPrefs.SetInt("IsButton_3_Active", 0);
                PlayerPrefs.SetInt("IsButton_4_Active", 0);
                PlayerPrefs.SetInt("IsButton_5_Active", 0);
                PlayerPrefs.SetInt("IsButton_6_Active", 0);
                PlayerPrefs.SetInt("IsButton_7_Active", 0);
                PlayerPrefs.SetInt("IsButton_8_Active", 0);
                PlayerPrefs.SetInt("IsButton_9_Active", 0);
                PlayerPrefs.SetInt("IsButton_10_Active", 0);
                PlayerPrefs.SetInt("IsButton_11_Active", 0);
                PlayerPrefs.SetInt("IsButton_12_Active", 0);
                PlayerPrefs.SetInt("IsButton_13_Active", 0);
                PlayerPrefs.SetInt("IsButtonHave_2_ADS_", 1); // 1 - нет 0 - есть
                PlayerPrefs.SetInt("IsButton_2_Active", 1);
                PlayerPrefs.SetInt("ChickenIndex", 1);

                Ok_1.SetActive(false);
                Ok_3.SetActive(false);
                Ok_4.SetActive(false);
                Ok_5.SetActive(false);
                Ok_6.SetActive(false);
                Ok_7.SetActive(false);
                Ok_8.SetActive(false);
                Ok_9.SetActive(false);
                Ok_10.SetActive(false);
                Ok_11.SetActive(false);
                Ok_12.SetActive(false);
                Ok_13.SetActive(false);
                Skins_Button_1.SetActive(true);
                Skins_Button_3.SetActive(true);
                Skins_Button_5.SetActive(true);
                Skins_Button_7.SetActive(true);
                Skins_Button_8.SetActive(true);
                Skins_Button_10.SetActive(true);
                Skins_Button_12.SetActive(true);
                Skins_Button_13.SetActive(true);

                if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
                {
                    Skins_Button_4.SetActive(false);
                    Ads_4.SetActive(true);
                }
                if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
                {
                    Skins_Button_6.SetActive(false);
                    Ads_6.SetActive(true);
                }
                if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
                {
                    Skins_Button_9.SetActive(false);
                    Ads_9.SetActive(true);
                }
                if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
                {
                    Skins_Button_11.SetActive(false);
                    Ads_11.SetActive(true);
                }

                Skins_Button_2.SetActive(false);
                Ok_2.SetActive(true);
                LevelScoreLabel++;
                PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
                _AdsIs = false;
            }
        }

    }
    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            _AdsIs = true;
        }
        if (result == ShowResult.Skipped)
        {
            _AdsIs = false;

        }
        if (result == ShowResult.Failed)
        {
            _AdsIs = false;
        }
    }

    public void ChangeToChicken_2()
    {
        GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
        PlayerPrefs.SetInt("IsButton_1_Active", 0);
        PlayerPrefs.SetInt("IsButton_2_Active", 0);
        PlayerPrefs.SetInt("IsButton_3_Active", 1);
        PlayerPrefs.SetInt("IsButton_4_Active", 0);
        PlayerPrefs.SetInt("IsButton_5_Active", 0);
        PlayerPrefs.SetInt("IsButton_6_Active", 0);
        PlayerPrefs.SetInt("IsButton_7_Active", 0);
        PlayerPrefs.SetInt("IsButton_8_Active", 0);
        PlayerPrefs.SetInt("IsButton_9_Active", 0);
        PlayerPrefs.SetInt("IsButton_10_Active", 0);
        PlayerPrefs.SetInt("IsButton_11_Active", 0);
        PlayerPrefs.SetInt("IsButton_12_Active", 0);
        PlayerPrefs.SetInt("IsButton_13_Active", 0);
        PlayerPrefs.SetInt("ChickenIndex", 2);
        if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 0)
        {
            Skins_Button_2.SetActive(true);
        }
        else { Ads_1.SetActive(true); }
        Skins_Button_1.SetActive(true);
        Ok_1.SetActive(false);
        Ok_2.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 0)
        {
            Skins_Button_4.SetActive(true);
        }
        else { Ads_4.SetActive(true); }
        Skins_Button_5.SetActive(true);
        Ok_4.SetActive(false);
        Ok_5.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 0)
        {
            Skins_Button_6.SetActive(true);
        }
        else { Ads_6.SetActive(true); }
        Skins_Button_7.SetActive(true);
        Ok_6.SetActive(false);
        Ok_7.SetActive(false);
        Skins_Button_8.SetActive(true);
        Ok_8.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 0)
        {
            Skins_Button_9.SetActive(true);
        }
        else { Ads_9.SetActive(true); }
        Ok_9.SetActive(false);
        Skins_Button_10.SetActive(true);
        Ok_10.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 0)
        {
            Skins_Button_11.SetActive(true);
        }
        else { Ads_11.SetActive(true); }
        Skins_Button_12.SetActive(true);
        Ok_11.SetActive(false);
        Skins_Button_13.SetActive(true);

        Skins_Button_3.SetActive(false);
        Ok_3.SetActive(true);
        LevelScoreLabel++;
        PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
    }

    public void ChangeToChicken_3()
    {
        if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
            PlayerPrefs.SetInt("IsButton_1_Active", 0);
            PlayerPrefs.SetInt("IsButton_2_Active", 0);
            PlayerPrefs.SetInt("IsButton_3_Active", 0);
            PlayerPrefs.SetInt("IsButton_4_Active", 1);
            PlayerPrefs.SetInt("IsButton_5_Active", 0);
            PlayerPrefs.SetInt("IsButton_6_Active", 0);
            PlayerPrefs.SetInt("IsButton_7_Active", 0);
            PlayerPrefs.SetInt("IsButton_8_Active", 0);
            PlayerPrefs.SetInt("IsButton_9_Active", 0);
            PlayerPrefs.SetInt("IsButton_10_Active", 0);
            PlayerPrefs.SetInt("IsButton_11_Active", 0);
            PlayerPrefs.SetInt("IsButton_12_Active", 0);
            PlayerPrefs.SetInt("IsButton_13_Active", 0);
            PlayerPrefs.SetInt("ChickenIndex", 3);
            Skins_Button_1.SetActive(true);
            Ok_1.SetActive(false);
            if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 0)
            {
                Skins_Button_2.SetActive(true);
            }
            else { Ads_1.SetActive(true); }
            Ok_2.SetActive(false);
            Skins_Button_3.SetActive(true);
            Ok_3.SetActive(false);
            Skins_Button_5.SetActive(true);
            Ok_5.SetActive(false);
            if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 0)
            {
                Skins_Button_6.SetActive(true);
            }
            else { Ads_6.SetActive(true); }
            Ok_6.SetActive(false);
            Skins_Button_7.SetActive(true);
            Ok_7.SetActive(false);
            Skins_Button_8.SetActive(true);
            Ok_8.SetActive(false);
            if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
            {
                Skins_Button_9.SetActive(false);
                Ads_9.SetActive(true);
            }
            Ok_9.SetActive(false);
            Skins_Button_10.SetActive(true);
            Ok_10.SetActive(false);
            if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 0)
            {
                Skins_Button_11.SetActive(true);
            }
            else { Ads_11.SetActive(true); }
            Ok_11.SetActive(false);
            Skins_Button_12.SetActive(true);
            Ok_12.SetActive(false);
            Skins_Button_13.SetActive(true);
            Ok_13.SetActive(false);
            Ads_4.SetActive(false);
            Ok_4.SetActive(true);
            Skins_Button_4.SetActive(false);
            LevelScoreLabel++;
            PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);

        }
        else
        {
            if (Monetization.IsReady("rewardedVideo"))
            {
                ShowAdCallbacks options = new ShowAdCallbacks();
                options.finishCallback = HandleShowResult;
                ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
                ad.Show(options);
            }
            if (_AdsIs == true)
            {
                GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
                PlayerPrefs.SetInt("IsButtonHave_4_ADS_", 1);
                PlayerPrefs.SetInt("IsButton_1_Active", 0);
                PlayerPrefs.SetInt("IsButton_2_Active", 0);
                PlayerPrefs.SetInt("IsButton_3_Active", 0);
                PlayerPrefs.SetInt("IsButton_4_Active", 1);
                PlayerPrefs.SetInt("IsButton_5_Active", 0);
                PlayerPrefs.SetInt("IsButton_6_Active", 0);
                PlayerPrefs.SetInt("IsButton_7_Active", 0);
                PlayerPrefs.SetInt("IsButton_8_Active", 0);
                PlayerPrefs.SetInt("IsButton_9_Active", 0);
                PlayerPrefs.SetInt("IsButton_10_Active", 0);
                PlayerPrefs.SetInt("IsButton_11_Active", 0);
                PlayerPrefs.SetInt("IsButton_12_Active", 0);
                PlayerPrefs.SetInt("IsButton_13_Active", 0);
                PlayerPrefs.SetInt("ChickenIndex", 3);
                if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
                {
                    Skins_Button_2.SetActive(false);
                    Ads_1.SetActive(true);
                }
                Ok_2.SetActive(false);
                Skins_Button_3.SetActive(true);
                Skins_Button_1.SetActive(true);
                Ok_1.SetActive(false);
                Skins_Button_5.SetActive(true);
                if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
                {
                    Skins_Button_6.SetActive(false);
                    Ads_6.SetActive(true);
                }
                Skins_Button_7.SetActive(true);
                Ok_7.SetActive(false);
                Skins_Button_8.SetActive(true);
                Ok_8.SetActive(false);
                if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
                {
                    Skins_Button_9.SetActive(false);
                    Ads_9.SetActive(true);
                }
                Skins_Button_10.SetActive(true);
                Ok_10.SetActive(false);
                if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
                {
                    Skins_Button_11.SetActive(false);
                    Ads_11.SetActive(true);
                }
                Skins_Button_12.SetActive(true);
                Skins_Button_13.SetActive(true);

                Skins_Button_4.SetActive(false);
                Ok_4.SetActive(true);
                LevelScoreLabel++;
                PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
                _AdsIs = false;
            }
        }

    }

    public void ChangeToChicken_4()
    {
        GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
        PlayerPrefs.SetInt("IsButton_1_Active", 0);
        PlayerPrefs.SetInt("IsButton_2_Active", 0);
        PlayerPrefs.SetInt("IsButton_3_Active", 0);
        PlayerPrefs.SetInt("IsButton_4_Active", 0);
        PlayerPrefs.SetInt("IsButton_5_Active", 1);
        PlayerPrefs.SetInt("IsButton_6_Active", 0);
        PlayerPrefs.SetInt("IsButton_7_Active", 0);
        PlayerPrefs.SetInt("IsButton_8_Active", 0);
        PlayerPrefs.SetInt("IsButton_9_Active", 0);
        PlayerPrefs.SetInt("IsButton_10_Active", 0);
        PlayerPrefs.SetInt("IsButton_11_Active", 0);
        PlayerPrefs.SetInt("IsButton_12_Active", 0);
        PlayerPrefs.SetInt("IsButton_13_Active", 0);
        PlayerPrefs.SetInt("ChickenIndex", 4);
        Skins_Button_2.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
        {
            Skins_Button_2.SetActive(false);
            Ads_1.SetActive(true);
        }
        Ok_2.SetActive(false);
        Skins_Button_3.SetActive(true);
        Skins_Button_4.SetActive(true);
        Skins_Button_1.SetActive(true);
        Ok_1.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
        {
            Skins_Button_6.SetActive(false);
            Ads_6.SetActive(true);
        }
        Skins_Button_7.SetActive(true);
        Ok_7.SetActive(false);
        Skins_Button_8.SetActive(true);
        Ok_8.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
        {
            Skins_Button_9.SetActive(false);
            Ads_9.SetActive(true);
        }
        Skins_Button_10.SetActive(true);
        Ok_10.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
        {
            Skins_Button_11.SetActive(false);
            Ads_11.SetActive(true);
        }
        Skins_Button_12.SetActive(true);
        Skins_Button_13.SetActive(true);

        Skins_Button_5.SetActive(false);
        Ok_5.SetActive(true);
        LevelScoreLabel++;
        PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
    }

    public void ChangeToChicken_5()
    {
        if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
            PlayerPrefs.SetInt("IsButton_1_Active", 0);
            PlayerPrefs.SetInt("IsButton_2_Active", 0);
            PlayerPrefs.SetInt("IsButton_3_Active", 0);
            PlayerPrefs.SetInt("IsButton_4_Active", 0);
            PlayerPrefs.SetInt("IsButton_5_Active", 0);
            PlayerPrefs.SetInt("IsButton_6_Active", 1);
            PlayerPrefs.SetInt("IsButton_7_Active", 0);
            PlayerPrefs.SetInt("IsButton_8_Active", 0);
            PlayerPrefs.SetInt("IsButton_9_Active", 0);
            PlayerPrefs.SetInt("IsButton_10_Active", 0);
            PlayerPrefs.SetInt("IsButton_11_Active", 0);
            PlayerPrefs.SetInt("IsButton_12_Active", 0);
            PlayerPrefs.SetInt("IsButton_13_Active", 0);
            PlayerPrefs.SetInt("ChickenIndex", 5);

            Ok_1.SetActive(false);
            Ok_3.SetActive(false);
            Ok_4.SetActive(false);
            Ok_5.SetActive(false);
            Ok_2.SetActive(false);
            Ok_7.SetActive(false);
            Ok_8.SetActive(false);
            Ok_9.SetActive(false);
            Ok_10.SetActive(false);
            Ok_11.SetActive(false);
            Ok_12.SetActive(false);
            Ok_13.SetActive(false);
            Skins_Button_1.SetActive(true);
            Skins_Button_3.SetActive(true);
            Skins_Button_5.SetActive(true);
            Skins_Button_7.SetActive(true);
            Skins_Button_8.SetActive(true);
            Skins_Button_10.SetActive(true);
            Skins_Button_12.SetActive(true);
            Skins_Button_13.SetActive(true);

            if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
            {
                Skins_Button_4.SetActive(false);
                Ads_4.SetActive(true);
            }
            if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
            {
                Skins_Button_2.SetActive(false);
                Ads_1.SetActive(true);
            }
            if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
            {
                Skins_Button_9.SetActive(false);
                Ads_9.SetActive(true);
            }
            if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
            {
                Skins_Button_11.SetActive(false);
                Ads_11.SetActive(true);
            }

            Ads_6.SetActive(false);
            Skins_Button_6.SetActive(false);
            Ok_6.SetActive(true);
            LevelScoreLabel++;
            PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);

        }
        else
        {
            if (Monetization.IsReady("rewardedVideo"))
            {
                ShowAdCallbacks options = new ShowAdCallbacks();
                options.finishCallback = HandleShowResult;
                ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
                ad.Show(options);
            }
            if (_AdsIs == true)
            {
                GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
                PlayerPrefs.SetInt("IsButtonHave_6_ADS_", 1);
                PlayerPrefs.SetInt("IsButton_1_Active", 0);
                PlayerPrefs.SetInt("IsButton_2_Active", 0);
                PlayerPrefs.SetInt("IsButton_3_Active", 0);
                PlayerPrefs.SetInt("IsButton_4_Active", 0);
                PlayerPrefs.SetInt("IsButton_5_Active", 0);
                PlayerPrefs.SetInt("IsButton_6_Active", 1);
                PlayerPrefs.SetInt("IsButton_7_Active", 0);
                PlayerPrefs.SetInt("IsButton_8_Active", 0);
                PlayerPrefs.SetInt("IsButton_9_Active", 0);
                PlayerPrefs.SetInt("IsButton_10_Active", 0);
                PlayerPrefs.SetInt("IsButton_11_Active", 0);
                PlayerPrefs.SetInt("IsButton_12_Active", 0);
                PlayerPrefs.SetInt("IsButton_13_Active", 0);
                PlayerPrefs.SetInt("ChickenIndex", 5);
                Ok_1.SetActive(false);
                Ok_3.SetActive(false);
                Ok_4.SetActive(false);
                Ok_5.SetActive(false);
                Ok_2.SetActive(false);
                Ok_7.SetActive(false);
                Ok_8.SetActive(false);
                Ok_9.SetActive(false);
                Ok_10.SetActive(false);
                Ok_11.SetActive(false);
                Ok_12.SetActive(false);
                Ok_13.SetActive(false);
                Skins_Button_1.SetActive(true);
                Skins_Button_3.SetActive(true);
                Skins_Button_5.SetActive(true);
                Skins_Button_7.SetActive(true);
                Skins_Button_8.SetActive(true);
                Skins_Button_10.SetActive(true);
                Skins_Button_12.SetActive(true);
                Skins_Button_13.SetActive(true);

                if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
                {
                    Skins_Button_4.SetActive(false);
                    Ads_4.SetActive(true);
                }
                if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
                {
                    Skins_Button_2.SetActive(false);
                    Ads_1.SetActive(true);
                }
                if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
                {
                    Skins_Button_9.SetActive(false);
                    Ads_9.SetActive(true);
                }
                if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
                {
                    Skins_Button_11.SetActive(false);
                    Ads_11.SetActive(true);
                }

                Skins_Button_6.SetActive(false);
                Ads_6.SetActive(false);
                Ok_6.SetActive(true);
                LevelScoreLabel++;
                PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
                _AdsIs = false;
            }
        }
    }

    public void ChangeToChicken_6()
    {
        GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
        PlayerPrefs.SetInt("IsButton_1_Active", 0);
        PlayerPrefs.SetInt("IsButton_2_Active", 0);
        PlayerPrefs.SetInt("IsButton_3_Active", 0);
        PlayerPrefs.SetInt("IsButton_4_Active", 0);
        PlayerPrefs.SetInt("IsButton_5_Active", 0);
        PlayerPrefs.SetInt("IsButton_6_Active", 0);
        PlayerPrefs.SetInt("IsButton_7_Active", 1);
        PlayerPrefs.SetInt("IsButton_8_Active", 0);
        PlayerPrefs.SetInt("IsButton_9_Active", 0);
        PlayerPrefs.SetInt("IsButton_10_Active", 0);
        PlayerPrefs.SetInt("IsButton_11_Active", 0);
        PlayerPrefs.SetInt("IsButton_12_Active", 0);
        PlayerPrefs.SetInt("IsButton_13_Active", 0);
        PlayerPrefs.SetInt("ChickenIndex", 6);
        if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
        {
            Skins_Button_2.SetActive(false);
            Ads_1.SetActive(true);
        }
        Ok_2.SetActive(false);
        Skins_Button_3.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
        {
            Skins_Button_4.SetActive(false);
            Ads_4.SetActive(true);
        }
        Skins_Button_5.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
        {
            Skins_Button_6.SetActive(false);
            Ads_6.SetActive(true);
        }
        Skins_Button_1.SetActive(true);
        Ok_1.SetActive(false);
        Skins_Button_8.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
        {
            Skins_Button_9.SetActive(false);
            Ads_9.SetActive(true);
        }
        Skins_Button_10.SetActive(true);
        Ok_10.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
        {
            Skins_Button_11.SetActive(false);
            Ads_11.SetActive(true);
        }
        Skins_Button_12.SetActive(true);
        Skins_Button_13.SetActive(true);

        Skins_Button_7.SetActive(false);
        Ok_7.SetActive(true);
        LevelScoreLabel++;
        PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
    }

    public void ChangeToChicken_7()
    {
        GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
        PlayerPrefs.SetInt("IsButton_1_Active", 0);
        PlayerPrefs.SetInt("IsButton_2_Active", 0);
        PlayerPrefs.SetInt("IsButton_3_Active", 0);
        PlayerPrefs.SetInt("IsButton_4_Active", 0);
        PlayerPrefs.SetInt("IsButton_5_Active", 0);
        PlayerPrefs.SetInt("IsButton_6_Active", 0);
        PlayerPrefs.SetInt("IsButton_7_Active", 0);
        PlayerPrefs.SetInt("IsButton_8_Active", 1);
        PlayerPrefs.SetInt("IsButton_9_Active", 0);
        PlayerPrefs.SetInt("IsButton_10_Active", 0);
        PlayerPrefs.SetInt("IsButton_11_Active", 0);
        PlayerPrefs.SetInt("IsButton_12_Active", 0);
        PlayerPrefs.SetInt("IsButton_13_Active", 0);
        PlayerPrefs.SetInt("ChickenIndex", 7);
        if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
        {
            Skins_Button_2.SetActive(false);
            Ads_1.SetActive(true);
        }
        Ok_2.SetActive(false);
        Skins_Button_3.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
        {
            Skins_Button_4.SetActive(false);
            Ads_4.SetActive(true);
        }
        Skins_Button_5.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
        {
            Skins_Button_6.SetActive(false);
            Ads_6.SetActive(true);
        }
        Skins_Button_7.SetActive(true);
        Skins_Button_1.SetActive(true);
        Ok_1.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
        {
            Skins_Button_9.SetActive(false);
            Ads_9.SetActive(true);
        }
        Skins_Button_10.SetActive(true);
        Ok_10.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
        {
            Skins_Button_11.SetActive(false);
            Ads_11.SetActive(true);
        }
        Skins_Button_12.SetActive(true);
        Skins_Button_13.SetActive(true);

        Skins_Button_8.SetActive(false);
        Ok_8.SetActive(true);
        LevelScoreLabel++;
        PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
    }

    public void ChangeToChicken_8()
    {
        if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
            PlayerPrefs.SetInt("IsButton_1_Active", 0);
            PlayerPrefs.SetInt("IsButton_2_Active", 0);
            PlayerPrefs.SetInt("IsButton_3_Active", 0);
            PlayerPrefs.SetInt("IsButton_4_Active", 0);
            PlayerPrefs.SetInt("IsButton_5_Active", 0);
            PlayerPrefs.SetInt("IsButton_6_Active", 0);
            PlayerPrefs.SetInt("IsButton_7_Active", 0);
            PlayerPrefs.SetInt("IsButton_8_Active", 0);
            PlayerPrefs.SetInt("IsButton_9_Active", 1);
            PlayerPrefs.SetInt("IsButton_10_Active", 0);
            PlayerPrefs.SetInt("IsButton_11_Active", 0);
            PlayerPrefs.SetInt("IsButton_12_Active", 0);
            PlayerPrefs.SetInt("IsButton_13_Active", 0);
            PlayerPrefs.SetInt("ChickenIndex", 8);
            Skins_Button_1.SetActive(true);
            Ok_1.SetActive(false);
            if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
            {
                Skins_Button_2.SetActive(false);
                Ads_1.SetActive(true);
            }
            Skins_Button_3.SetActive(true);
            Ok_3.SetActive(false);
            Skins_Button_5.SetActive(true);
            Ok_5.SetActive(false);
            if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
            {
                Skins_Button_4.SetActive(false);
                Ads_4.SetActive(true);
            }
            if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
            {
                Skins_Button_6.SetActive(false);
                Ads_6.SetActive(true);
            }
            Skins_Button_7.SetActive(true);
            Ok_7.SetActive(false);
            Skins_Button_8.SetActive(true);
            Ok_8.SetActive(false);
            Skins_Button_10.SetActive(true);
            Ok_10.SetActive(false);
            if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
            {
                Skins_Button_11.SetActive(false);
                Ads_11.SetActive(true);
            }
            Skins_Button_12.SetActive(true);
            Ok_12.SetActive(false);
            Skins_Button_13.SetActive(true);
            Ok_13.SetActive(false);
            Ads_9.SetActive(false);
            Skins_Button_9.SetActive(false);
            Ok_9.SetActive(true);
            LevelScoreLabel++;
            PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);

        }
        else
        {
            if (Monetization.IsReady("rewardedVideo"))
            {
                ShowAdCallbacks options = new ShowAdCallbacks();
                options.finishCallback = HandleShowResult;
                ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
                ad.Show(options);
            }
            if (_AdsIs == true)
            {
                GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
                PlayerPrefs.SetInt("IsButtonHave_9_ADS_", 1);
                PlayerPrefs.SetInt("IsButton_1_Active", 0);
                PlayerPrefs.SetInt("IsButton_2_Active", 0);
                PlayerPrefs.SetInt("IsButton_3_Active", 0);
                PlayerPrefs.SetInt("IsButton_4_Active", 0);
                PlayerPrefs.SetInt("IsButton_5_Active", 0);
                PlayerPrefs.SetInt("IsButton_6_Active", 0);
                PlayerPrefs.SetInt("IsButton_7_Active", 0);
                PlayerPrefs.SetInt("IsButton_8_Active", 0);
                PlayerPrefs.SetInt("IsButton_9_Active", 1);
                PlayerPrefs.SetInt("IsButton_10_Active", 0);
                PlayerPrefs.SetInt("IsButton_11_Active", 0);
                PlayerPrefs.SetInt("IsButton_12_Active", 0);
                PlayerPrefs.SetInt("IsButton_13_Active", 0);
                PlayerPrefs.SetInt("ChickenIndex", 8);
                if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
                {
                    Skins_Button_2.SetActive(false);
                    Ads_1.SetActive(true);
                }
                Ok_2.SetActive(false);
                Skins_Button_3.SetActive(true);
                if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
                {
                    Skins_Button_4.SetActive(false);
                    Ads_4.SetActive(true);
                }
                Skins_Button_5.SetActive(true);
                if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
                {
                    Skins_Button_6.SetActive(false);
                    Ads_6.SetActive(true);
                }
                Skins_Button_7.SetActive(true);
                Skins_Button_8.SetActive(true);
                Skins_Button_1.SetActive(true);
                Ok_1.SetActive(false);
                Skins_Button_10.SetActive(true);
                if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
                {
                    Skins_Button_9.SetActive(false);
                    Ads_9.SetActive(true);
                }
                Skins_Button_12.SetActive(true);
                Skins_Button_13.SetActive(true);

                Skins_Button_9.SetActive(false);
                Ads_9.SetActive(false);
                Ok_9.SetActive(true);
                LevelScoreLabel++;
                PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
                _AdsIs = false;
            }
        }

    }

    public void ChangeToChicken_9()
    {
        GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
        PlayerPrefs.SetInt("IsButton_1_Active", 0);
        PlayerPrefs.SetInt("IsButton_2_Active", 0);
        PlayerPrefs.SetInt("IsButton_3_Active", 0);
        PlayerPrefs.SetInt("IsButton_4_Active", 0);
        PlayerPrefs.SetInt("IsButton_5_Active", 0);
        PlayerPrefs.SetInt("IsButton_6_Active", 0);
        PlayerPrefs.SetInt("IsButton_7_Active", 0);
        PlayerPrefs.SetInt("IsButton_8_Active", 0);
        PlayerPrefs.SetInt("IsButton_9_Active", 0);
        PlayerPrefs.SetInt("IsButton_10_Active", 1);
        PlayerPrefs.SetInt("IsButton_11_Active", 0);
        PlayerPrefs.SetInt("IsButton_12_Active", 0);
        PlayerPrefs.SetInt("IsButton_13_Active", 0);
        PlayerPrefs.SetInt("ChickenIndex", 9);
        if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
        {
            Skins_Button_2.SetActive(false);
            Ads_1.SetActive(true);
        }
        Ok_2.SetActive(false);
        Skins_Button_3.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
        {
            Skins_Button_4.SetActive(false);
            Ads_4.SetActive(true);
        }
        Skins_Button_5.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
        {
            Skins_Button_6.SetActive(false);
            Ads_6.SetActive(true);
        }
        Skins_Button_7.SetActive(true);
        Skins_Button_8.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
        {
            Skins_Button_9.SetActive(false);
            Ads_9.SetActive(true);
        }
        Skins_Button_1.SetActive(true);
        Ok_1.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
        {
            Skins_Button_11.SetActive(false);
            Ads_11.SetActive(true);
        }
        Skins_Button_12.SetActive(true);
        Skins_Button_13.SetActive(true);

        Skins_Button_10.SetActive(false);
        Ok_10.SetActive(true);
        LevelScoreLabel++;
        PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
    }

    public void ChangeToChicken_10()
    {
        if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
            PlayerPrefs.SetInt("IsButton_1_Active", 0);
            PlayerPrefs.SetInt("IsButton_2_Active", 0);
            PlayerPrefs.SetInt("IsButton_3_Active", 0);
            PlayerPrefs.SetInt("IsButton_4_Active", 0);
            PlayerPrefs.SetInt("IsButton_5_Active", 0);
            PlayerPrefs.SetInt("IsButton_6_Active", 0);
            PlayerPrefs.SetInt("IsButton_7_Active", 0);
            PlayerPrefs.SetInt("IsButton_8_Active", 0);
            PlayerPrefs.SetInt("IsButton_9_Active", 0);
            PlayerPrefs.SetInt("IsButton_10_Active", 0);
            PlayerPrefs.SetInt("IsButton_11_Active", 1);
            PlayerPrefs.SetInt("IsButton_12_Active", 0);
            PlayerPrefs.SetInt("IsButton_13_Active", 0);
            PlayerPrefs.SetInt("ChickenIndex", 10);

            Ok_1.SetActive(false);
            Ok_3.SetActive(false);
            Ok_4.SetActive(false);
            Ok_5.SetActive(false);
            Ok_2.SetActive(false);
            Ok_7.SetActive(false);
            Ok_8.SetActive(false);
            Ok_9.SetActive(false);
            Ok_10.SetActive(false);
            Ok_6.SetActive(false);
            Ok_12.SetActive(false);
            Ok_13.SetActive(false);
            Skins_Button_1.SetActive(true);
            Skins_Button_3.SetActive(true);
            Skins_Button_5.SetActive(true);
            Skins_Button_7.SetActive(true);
            Skins_Button_8.SetActive(true);
            Skins_Button_10.SetActive(true);
            Skins_Button_12.SetActive(true);
            Skins_Button_13.SetActive(true);

            if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
            {
                Skins_Button_4.SetActive(false);
                Ads_4.SetActive(true);
            }
            if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
            {
                Skins_Button_2.SetActive(false);
                Ads_1.SetActive(true);
            }
            if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
            {
                Skins_Button_9.SetActive(false);
                Ads_9.SetActive(true);
            }
            if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
            {
                Skins_Button_6.SetActive(false);
                Ads_6.SetActive(true);
            }

            Ads_11.SetActive(false);
            Skins_Button_11.SetActive(false);
            Ok_11.SetActive(true);
            LevelScoreLabel++;
            PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);

        }
        else
        {
            if (Monetization.IsReady("rewardedVideo"))
            {
                ShowAdCallbacks options = new ShowAdCallbacks();
                options.finishCallback = HandleShowResult;
                ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
                ad.Show(options);
            }
            if (_AdsIs == true)
            {
                GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
                PlayerPrefs.SetInt("IsButtonHave_11_ADS_", 1);
                PlayerPrefs.SetInt("IsButton_1_Active", 0);
                PlayerPrefs.SetInt("IsButton_2_Active", 0);
                PlayerPrefs.SetInt("IsButton_3_Active", 0);
                PlayerPrefs.SetInt("IsButton_4_Active", 0);
                PlayerPrefs.SetInt("IsButton_5_Active", 0);
                PlayerPrefs.SetInt("IsButton_6_Active", 0);
                PlayerPrefs.SetInt("IsButton_7_Active", 0);
                PlayerPrefs.SetInt("IsButton_8_Active", 0);
                PlayerPrefs.SetInt("IsButton_9_Active", 0);
                PlayerPrefs.SetInt("IsButton_10_Active", 0);
                PlayerPrefs.SetInt("IsButton_11_Active", 1);
                PlayerPrefs.SetInt("IsButton_12_Active", 0);
                PlayerPrefs.SetInt("IsButton_13_Active", 0);
                PlayerPrefs.SetInt("ChickenIndex", 10);
                Ok_1.SetActive(false);
                Ok_3.SetActive(false);
                Ok_4.SetActive(false);
                Ok_5.SetActive(false);
                Ok_2.SetActive(false);
                Ok_7.SetActive(false);
                Ok_8.SetActive(false);
                Ok_9.SetActive(false);
                Ok_10.SetActive(false);
                Ok_6.SetActive(false);
                Ok_12.SetActive(false);
                Ok_13.SetActive(false);
                Skins_Button_1.SetActive(true);
                Skins_Button_3.SetActive(true);
                Skins_Button_5.SetActive(true);
                Skins_Button_7.SetActive(true);
                Skins_Button_8.SetActive(true);
                Skins_Button_10.SetActive(true);
                Skins_Button_12.SetActive(true);
                Skins_Button_13.SetActive(true);

                if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
                {
                    Skins_Button_4.SetActive(false);
                    Ads_4.SetActive(true);
                }
                if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
                {
                    Skins_Button_2.SetActive(false);
                    Ads_1.SetActive(true);
                }
                if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
                {
                    Skins_Button_9.SetActive(false);
                    Ads_9.SetActive(true);
                }
                if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
                {
                    Skins_Button_6.SetActive(false);
                    Ads_6.SetActive(true);
                }

                Skins_Button_11.SetActive(false);
                Ok_11.SetActive(true);
                Ads_11.SetActive(false);
                LevelScoreLabel++;
                PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
                _AdsIs = false;
            }
        }

    }

    public void ChangeToChicken_11()
    {
        GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
        PlayerPrefs.SetInt("IsButton_1_Active", 0);
        PlayerPrefs.SetInt("IsButton_2_Active", 0);
        PlayerPrefs.SetInt("IsButton_3_Active", 0);
        PlayerPrefs.SetInt("IsButton_4_Active", 0);
        PlayerPrefs.SetInt("IsButton_5_Active", 0);
        PlayerPrefs.SetInt("IsButton_6_Active", 0);
        PlayerPrefs.SetInt("IsButton_7_Active", 0);
        PlayerPrefs.SetInt("IsButton_8_Active", 0);
        PlayerPrefs.SetInt("IsButton_9_Active", 0);
        PlayerPrefs.SetInt("IsButton_10_Active", 0);
        PlayerPrefs.SetInt("IsButton_11_Active", 0);
        PlayerPrefs.SetInt("IsButton_12_Active", 1);
        PlayerPrefs.SetInt("IsButton_13_Active", 0);
        PlayerPrefs.SetInt("ChickenIndex", 11);
        if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
        {
            Skins_Button_2.SetActive(false);
            Ads_1.SetActive(true);
        }
        Ok_2.SetActive(false);
        Skins_Button_3.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
        {
            Skins_Button_4.SetActive(false);
            Ads_4.SetActive(true);
        }
        Skins_Button_5.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
        {
            Skins_Button_6.SetActive(false);
            Ads_6.SetActive(true);
        }
        Skins_Button_7.SetActive(true);
        Skins_Button_8.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
        {
            Skins_Button_9.SetActive(false);
            Ads_9.SetActive(true);
        }
        Skins_Button_1.SetActive(true);
        Ok_1.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
        {
            Skins_Button_11.SetActive(false);
            Ads_11.SetActive(true);
        }
        Skins_Button_1.SetActive(true);
        Skins_Button_13.SetActive(true);

        Skins_Button_12.SetActive(false);
        Ok_12.SetActive(true);
        LevelScoreLabel++;
        PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
    }

    public void ChangeToChicken_12()
    {
        GetComponent<AudioSource>().PlayOneShot(ChangeChickenClip);
        PlayerPrefs.SetInt("IsButton_1_Active", 0);
        PlayerPrefs.SetInt("IsButton_2_Active", 0);
        PlayerPrefs.SetInt("IsButton_3_Active", 0);
        PlayerPrefs.SetInt("IsButton_4_Active", 0);
        PlayerPrefs.SetInt("IsButton_5_Active", 0);
        PlayerPrefs.SetInt("IsButton_6_Active", 0);
        PlayerPrefs.SetInt("IsButton_7_Active", 0);
        PlayerPrefs.SetInt("IsButton_8_Active", 0);
        PlayerPrefs.SetInt("IsButton_9_Active", 0);
        PlayerPrefs.SetInt("IsButton_10_Active", 0);
        PlayerPrefs.SetInt("IsButton_11_Active", 0);
        PlayerPrefs.SetInt("IsButton_12_Active", 0);
        PlayerPrefs.SetInt("IsButton_13_Active", 1);
        PlayerPrefs.SetInt("ChickenIndex", 12);
        if (PlayerPrefs.GetInt("IsButtonHave_2_ADS_") == 1)
        {
            Skins_Button_2.SetActive(false);
            Ads_1.SetActive(true);
        }
        Ok_2.SetActive(false);
        Skins_Button_3.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_4_ADS_") == 1)
        {
            Skins_Button_4.SetActive(false);
            Ads_4.SetActive(true);
        }
        Skins_Button_5.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_6_ADS_") == 1)
        {
            Skins_Button_6.SetActive(false);
            Ads_6.SetActive(true);
        }
        Skins_Button_7.SetActive(true);
        Skins_Button_8.SetActive(true);
        if (PlayerPrefs.GetInt("IsButtonHave_9_ADS_") == 1)
        {
            Skins_Button_9.SetActive(false);
            Ads_9.SetActive(true);
        }
        Skins_Button_1.SetActive(true);
        Ok_1.SetActive(false);
        if (PlayerPrefs.GetInt("IsButtonHave_11_ADS_") == 1)
        {
            Skins_Button_11.SetActive(false);
            Ads_11.SetActive(true);
        }
        Skins_Button_12.SetActive(true);
        Skins_Button_1.SetActive(true);

        Skins_Button_13.SetActive(false);
        Ok_13.SetActive(true);
        LevelScoreLabel++;
        PlayerPrefs.SetInt("SkinsScore", LevelScoreLabel);
    }

    public void ToggleSoundTreck(bool enabled)
    {
        if (enabled)
        {
            SoundTreckMixer.audioMixer.SetFloat("SoundTreckVolume", 0);
            PlayerPrefs.SetInt("SoundTreckVolume", 0);
            Toggle_Music.SetActive(true);
        }
        else
        {
            SoundTreckMixer.audioMixer.SetFloat("SoundTreckVolume", -80);
            PlayerPrefs.SetInt("SoundTreckVolume", -80);
        }
        GetComponent<AudioSource>().PlayOneShot(ToggleChangeClip);
    }

    public void ToggleSounds(bool enabled)
    {
        if (enabled)
        {
            Sounds.audioMixer.SetFloat("SoundsVolume", 0);
            PlayerPrefs.SetInt("SoundsVolume", 0);
            Toggle_Sounds.SetActive(true);
        }
        else
        {
            Sounds.audioMixer.SetFloat("SoundsVolume", -80);
            PlayerPrefs.SetInt("SoundsVolume", -80);
        }
        GetComponent<AudioSource>().PlayOneShot(ToggleChangeClip);
    }

    public void OpenSoundButton()
    {
        GetComponent<AudioSource>().PlayOneShot(ButtonSoundOpen);
    }

    public void CloseSoundButton()
    {
        GetComponent<AudioSource>().PlayOneShot(ButtonSoundClose);
    }

    public void CloseSettings()
    {
        Settings.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("InputMenu") == 1)
        {
            Win_Menu.gameObject.SetActive(true);
        }
        else
        {
            Menu.gameObject.SetActive(true);
            if(PlayerPrefs.GetInt("IsDied") == 0)
            {
                Exit_from_Menu.SetActive(true);
            }
        }
    }

    public void OpenSettings()
    {
        Settings.gameObject.SetActive(true);
        Exit_from_Menu.SetActive(false);
        if (Win_Menu.activeSelf)
        {
            Win_Menu.SetActive(false);
            PlayerPrefs.SetInt("InputMenu", 1);
        }
        if (Menu.activeSelf)
        {
            Menu.SetActive(false);
            PlayerPrefs.SetInt("InputMenu", 0);
        }
    }

    public void ChangeLanguageSound()
    {
        GetComponent<AudioSource>().PlayOneShot(ChangeLanguageClip);
    }

}
