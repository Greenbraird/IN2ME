using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [Header("UI ����")]
    [SerializeField] Sound[] UISound;

    [Header("UI �÷��̾�")]
    [SerializeField] AudioSource[] UIPlayer;

    [Header("UI GameObject")]
    [SerializeField] GameObject[] UI_box; //compass, id, quest, inventory, settings, shop
    [SerializeField] GameObject[] UI_skill; //potion, skill_1, skill_2, skill_3
    [SerializeField] GameObject[] UI_joystick;
    [SerializeField] GameObject[] UI_state; //Scrollbar_1, Scrollbar_2


    public void PlayUI(string _soundName)
    {
        for (int i = 0; i < UISound.Length; i++)
        {
            if (_soundName == UISound[i].soundName)
            {
                for (int x = 0; x < UIPlayer.Length; x++)
                    if (!UIPlayer[x].isPlaying)
                    {
                        UIPlayer[x].clip = UISound[i].clip;
                        UIPlayer[x].PlayOneShot(UIPlayer[x].clip);
                        return;
                    }
            }
        }
    }

/*    void OnMouseDown(obj)
    {
        if (obj.CompareTag("compass"))
        {
            PlayUI("UI_SFX_����ȭ��");
        }
    }*/


    public void ui_SetActiveTrue(GameObject obj) //��Ϲ���(���� ��ư)�� ������ ��
    {
        PlayUI("UI_SFX_����ȭ��");
/*        if (setting.activeSelf == false)
        {
            setting.SetActive(true);
            blinder.SetActive(true);
        }
        else
        {
            Unactive_Sitting_UI();
        }
*/    }

    public void ui_SetActiveFalse() //���� UI�̰� SetActive(false)
    {
        PlayUI("UI_SFX_����ȭ��");
/*        setting.SetActive(false);
        blinder.SetActive(false);*/
    }

    public void On_Cleck_Joystickh() //����â�� ���̽�ƽ ��ư�� ������ �ʷϻ����� �ٲ�� ��ũ��Ʈ
    {
/*        SoundManager.instance.PlaySE("UI Click Sound");
        joystick.GetComponent<Image>().color = new Color32(0, 220, 3, 255);
        touch.GetComponent<Image>().color = new Color32(0, 0, 0, 100);*/
    }

    public void On_Cleck_Touch() //����â�� ��ġ ��ư�� ������ �ʷϻ����� �ٲ�� ��ũ��Ʈ
    {
/*        SoundManager.instance.PlaySE("UI Click Sound");
        joystick.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
        touch.GetComponent<Image>().color = new Color32(0, 220, 3, 255);*/
    }

    public void Active_Shop()
    {
/*        SoundManager.instance.PlaySE("UI Click Sound");
        shop.SetActive(true);*/
    }

    public void UnActive_Shop()
    {
/*        SoundManager.instance.PlaySE("UI Click Sound");
        shop.SetActive(false);
*/    }

    public void Input_Name()
    {
/*        Debug.Log("���� ����");*/

    }
}

