using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip clip;
}

// M1, M2 관련 sound 관리

public class S1_Sound : MonoBehaviour
{

    public static S1_Sound instance;

    [Header("사운드 등록")]
    [SerializeField] Sound[] opening_BGM;
    [SerializeField] Sound[] M1_BGM;
    [SerializeField] Sound[] M2_BGM;

    [SerializeField] Sound[] M1Amb_SFX;
    [SerializeField] Sound[] M2Amb_SFX;

    [SerializeField] Sound[] M1_Player_SFX; //player가 내는 모든 소리

    [SerializeField] Sound[] Npc_SFX; //npc가 내는 모든 소리
    [SerializeField] Sound[] Obj_SFX; //물체에서 나는 모든 소리


    [Header("브금 플레이어")]
    [SerializeField] AudioSource[] bgmPlayer;
    [SerializeField] AudioSource[] sfxPlayer;
    [SerializeField] AudioSource[] chSound;

    void Start()
    {
        instance = this;
    }


    //맵 BGM & Amb - tag, collider, random
    void update()
    {

    }

    //UI - tag

    //Player - 움직임 / loop 조절    

    //obj - tag

    /*
public double fadeOutSeconds = 1.0;
public double fadeInSeconds = 1.0;
double fadeDeltaTime = 0;
*/
    public void StopBGM(int x)
    {
        /*
        fadeDeltaTime = 0;
        fadeDeltaTime += Time.deltaTime;
        if (fadeDeltaTime >= fadeOutSeconds)
        {
            fadeDeltaTime = fadeOutSeconds;
        }
        sfxPlayer[x].volume = (float)(1.0 - (fadeDeltaTime / fadeOutSeconds));
        */
        sfxPlayer[x].Stop();
    }

    public int PlayBGM(string _soundName)
    {
        for (int i = 0; i < opening_BGM.Length; i++)
        {
            if (_soundName == opening_BGM[i].soundName)
            {
                for (int x = 0; x < sfxPlayer.Length; x++)
                    if (!sfxPlayer[x].isPlaying)
                    {
                        sfxPlayer[x].clip = opening_BGM[i].clip;
                        sfxPlayer[x].PlayOneShot(sfxPlayer[x].clip);
                        /*
                         * 이것 트는 순간 프로그램 멈춤 무한루프 ㅋㅋ
                        while(fadeDeltaTime <= fadeInSeconds)
                        {
                            fadeDeltaTime = 0;
                            fadeDeltaTime += Time.deltaTime;
                            sfxPlayer[x].volume = (float)(fadeDeltaTime / fadeInSeconds);

                            if (fadeDeltaTime > fadeInSeconds)
                                break;
                        }*/
                        return x;
                    }
            }

            else if (_soundName == M1_Player_SFX[i].soundName)
            {
                for (int x = 0; x < chSound.Length; x++)
                    if (!chSound[x].isPlaying)
                    {
                        chSound[x].clip = M1_Player_SFX[i].clip;
                        chSound[x].PlayOneShot(chSound[x].clip);
                        return x;
                    }
            }

            else if (_soundName == M1Amb_SFX[i].soundName)
            {
                for (int x = 0; x < sfxPlayer.Length; x++)
                    if (!sfxPlayer[x].isPlaying)
                    {
                        sfxPlayer[x].clip = M1Amb_SFX[i].clip;
                        sfxPlayer[x].PlayOneShot(sfxPlayer[x].clip);
                        return x;
                    }
            }

        }
        return 0;
    }

    public void PlaySFX(string _soundName)
    {
        for (int i = 0; i < opening_BGM.Length; i++)
        {
            if (_soundName == opening_BGM[i].soundName)
            {
                for (int x = 0; x < sfxPlayer.Length; x++)
                    if (!sfxPlayer[x].isPlaying)
                    {
                        sfxPlayer[x].clip = opening_BGM[i].clip;
                        sfxPlayer[x].PlayOneShot(sfxPlayer[x].clip);

                        /*
                        fadeDeltaTime = 0;
                        fadeDeltaTime += Time.deltaTime;
                        if (fadeDeltaTime >= fadeInSeconds)
                        {
                            fadeDeltaTime = fadeInSeconds;
                        }
                        sfxPlayer[x].volume = (float)(fadeDeltaTime / fadeInSeconds);
                        */return;
                    }
            }
        }
    }
    
}
