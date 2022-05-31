using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [Header("UI 사운드")]
    [SerializeField] Sound[] UISound;

    [Header("UI 플레이어")]
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
            PlayUI("UI_SFX_시작화면");
        }
    }*/


    public void ui_SetActiveTrue(GameObject obj) //톱니바퀴(셋팅 버튼)를 눌렀을 때
    {
        PlayUI("UI_SFX_시작화면");
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

    public void ui_SetActiveFalse() //셋팅 UI이가 SetActive(false)
    {
        PlayUI("UI_SFX_시작화면");
/*        setting.SetActive(false);
        blinder.SetActive(false);*/
    }

    public void On_Cleck_Joystickh() //설정창의 조이스틱 버튼을 누르면 초록색으로 바뀌는 스크립트
    {
/*        SoundManager.instance.PlaySE("UI Click Sound");
        joystick.GetComponent<Image>().color = new Color32(0, 220, 3, 255);
        touch.GetComponent<Image>().color = new Color32(0, 0, 0, 100);*/
    }

    public void On_Cleck_Touch() //설정창의 터치 버튼을 누르면 초록색으로 바뀌는 스크립트
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
/*        Debug.Log("값이 변함");*/

    }
}

