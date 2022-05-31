using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
/* scene ����
public class Sound
{
    public string soundName;
    public AudioClip clip;
}*/

// M3 ���� sound ����


public class S2_Sound : MonoBehaviour
{
    public static S2_Sound instance;

    [Header("���� ���")]
    [SerializeField] Sound[] M3_BGM;
    [SerializeField] Sound[] M3Amb_SFX;

    [SerializeField] Sound[] M3_Player_SFX; //M3���� player�� ���� ��� �Ҹ�

    [SerializeField] Sound[] Btl_BGM;
    [SerializeField] Sound[] Btl_SFX; //���� �� ȿ����, ��ų ����

    [SerializeField] Sound[] Npc_SFX; //npc�� ���� ��� �Ҹ�
    [SerializeField] Sound[] Obj_SFX; //��ü���� ���� ��� �Ҹ�


    //�� BGM & Amb - tag, collider, random

    //UI - tag

    //Player - ������ / loop ����

    //obj - tag


    [Header("��� �÷��̾�")]
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
