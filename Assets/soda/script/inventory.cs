using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print_inven_bysort();
    }

    // Update is called once per frame
    void Update()
    {
        //버튼을 누르면, 함수 1 출력
        //sorting();
    }

    //아이템을 먹으면 인벤토리 있는지 확인하고, 있으면 개수를 +1
    //만약 아이템을 먹으면, 아이템 이름을 item에 넘겨주고, for문 4개 돌려 item의 종류와 번호를 찾은 다음, 해당 인덱스의 정보를 inventory창으로 넘긴다 (return)

    //현재 나의 인벤토리
    int[,] item = new int[2,4] { //아이템 종류 / 아이템 번호 / 무게 / 아이템 개수
        {1, 1, 1, 1 }, 
        {1, 1, 1, 1 }
    };

    public void sorting()
    {
        return;
    }

    public void print_inven_bysort()
    {
        return;
    }



}
