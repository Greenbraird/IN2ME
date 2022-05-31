using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player : MonoBehaviour
{
    public float pushPower = 2.0f;

    [Header("문 list")]
    [SerializeField] Animator[] doorAnimation;

    public Animator autodoor;
    public GameObject item_;

    int m1 = 0;
    int m2 = 0;
    int m4 = 0;
    bool pointer = false;


    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
            return;

        if (hit.moveDirection.y < -0.3F)
            return;

        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.velocity = pushDir * pushPower;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("map_red"))
        {
            Debug.Log("충돌1!");
            m1 = S1_Sound.instance.PlayBGM("opening1_BGML");
        }

        else if (other.CompareTag("map_blue"))
        {
            Debug.Log("충돌2!");
            m2 = S1_Sound.instance.PlayBGM("opening2_BGML");
        }

        else if (other.CompareTag("autodoorsensor"))
        {
            Debug.Log("충돌3!");
            autodoor.Play("New Animation");
            m4 = S1_Sound.instance.PlayBGM("M1C_SFX1_Door1");

        }

        //문 sensor
        else if (other.transform.tag.Substring(0, 14) == "autodoorsensor")
        {
            Debug.Log("충돌3.1!");
            doorAnimation[int.Parse(other.transform.tag.Substring(14))].Play("New Animation");
            m4 = S1_Sound.instance.PlayBGM("M1C_SFX1_Door1");
        }

        else if (other.CompareTag("item"))
        {
            Debug.Log("충돌4!");
            item_ = other.gameObject;
            pointer = true;
            //other.GetComponent<"Mesh Render"> .materials[0] = 
        }

        else if (other.CompareTag("next"))
        {
            Debug.Log("다음맵으로!");
            chScene.nextScene();
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("map_red"))
        {
            Debug.Log("나감1!");
            S1_Sound.instance.StopBGM(m1);
        }

        else if (other.CompareTag("map_blue"))
        {
            Debug.Log("나감2!");
            S1_Sound.instance.StopBGM(m2);
        }

        else if (other.CompareTag("autodoorsensor"))
        {
            Debug.Log("나감3!");
            autodoor.Play("New Animation 0");
            m4= S1_Sound.instance.PlayBGM("M1C_SFX1_Door2");
        }

        //문 sensor
        else if (other.transform.tag.Substring(0, 14) == "autodoorsensor")
        {
            Debug.Log("충돌3.1!");
            doorAnimation[int.Parse(other.transform.tag.Substring(14))].Play("New Animation 0");
            m4 = S1_Sound.instance.PlayBGM("M1C_SFX1_Door2");
        }

        else if (other.CompareTag("item"))
        {
            Debug.Log("충돌4!");
            autodoor.Play("New Animation");
        }
    }

    //아니 이걸 어떻게 해야해징
    //Item 먹는 소리
    public void get_Item(bool pointer)
    {
        if (pointer)
        {
            Debug.Log("누름");
            item_.gameObject.SetActive(false);
        }

    }

}
