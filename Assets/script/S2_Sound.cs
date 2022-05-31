using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
/* scene 구분
public class Sound
{
    public string soundName;
    public AudioClip clip;
}*/

// M3 관련 sound 관리


public class S2_Sound : MonoBehaviour
{
    public static S2_Sound instance;

    [Header("사운드 등록")]
    [SerializeField] Sound[] M3_BGM;
    [SerializeField] Sound[] M3Amb_SFX;

    [SerializeField] Sound[] M3_Player_SFX; //M3에서 player가 내는 모든 소리

    [SerializeField] Sound[] Btl_BGM;
    [SerializeField] Sound[] Btl_SFX; //전투 중 효과음, 스킬 포함

    [SerializeField] Sound[] Npc_SFX; //npc가 내는 모든 소리
    [SerializeField] Sound[] Obj_SFX; //물체에서 나는 모든 소리


    //맵 BGM & Amb - tag, collider, random

    //UI - tag

    //Player - 움직임 / loop 조절

    //obj - tag


    [Header("브금 플레이어")]
    [SerializeField] AudioSource[] bgmPlayer;
    [SerializeField] AudioSource[] sfxPlayer;

    void Start()
    {
        instance = this;
    }

    public void PlaySE(string _soundName)
    {
        for (int i = 0; i < M3_BGM.Length; i++)
        {
            if (_soundName == M3_BGM[i].soundName)
            {
                for (int x = 0; x < sfxPlayer.Length; x++)
                    if (!sfxPlayer[x].isPlaying)
                    {
                        sfxPlayer[x].clip = M3_BGM[i].clip;
                        sfxPlayer[x].Play();
                        return;
                    }
            }
        }
    }

}
