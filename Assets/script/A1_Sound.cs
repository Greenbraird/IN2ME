using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1_Sound : MonoBehaviour
{
    public static A1_Sound instance;

    [Header("���� ���")]
    [SerializeField] Sound[] UI_SFX; //��ư�� â ��� �Ҹ�

    [Header("��� �÷��̾�")]
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
