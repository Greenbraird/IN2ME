using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item : MonoBehaviour
{
    [Header("3D Item")]
    [SerializeField] GameObject[] Item_3D_1;
    [SerializeField] GameObject[] Item_3D_2;
    [SerializeField] GameObject[] Item_3D_3;
    [SerializeField] GameObject[] Item_3D_4;

    [Header("2D Item")]
    [SerializeField] Sprite[] Item_2D_1;
    [SerializeField] Sprite[] Item_2D_2;
    [SerializeField] Sprite[] Item_2D_3;
    [SerializeField] Sprite[] Item_2D_4;

    //아이템 종류 당 item_mass 시작 인덱스
    int[] item_num = new int[] { 1, 2, 3, 4 };


    //아이템 무게    //아이템 종류 / 아이템 번호 / 무게 / 아이템 개수
    int[,] item_mass = new int[2,3] {
        {1, 1, 1 },
        {1, 1, 1 }
    };

    //아이템 무게 가져오기
    public int get_item(int A, int B)
    {
        return item_mass[item_num[A] + B,2];
    }
}
