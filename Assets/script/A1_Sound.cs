using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1_Sound : MonoBehaviour
{
    public static A1_Sound instance;

    [Header("사운드 등록")]
    [SerializeField] Sound[] UI_SFX; //버튼과 창 모든 소리

    [Header("브금 플레이어")]
    [SerializeField] AudioSource[] sfxPlayer;


    void Start()
    {
        instance = this;
    }

    public void PlaySE(string _soundName)
    {
        for (int i = 0; i < UI_SFX.Length; i++)
        {
            if (_soundName == UI_SFX[i].soundName)
            {
                for (int x = 0; x < sfxPlayer.Length; x++)
                    if (!sfxPlayer[x].isPlaying)
                    {
                        sfxPlayer[x].clip = UI_SFX[i].clip;
                        sfxPlayer[x].Play();
                        return;
                    }
            }
        }
    }

}
