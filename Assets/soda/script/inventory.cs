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
        //��ư�� ������, �Լ� 1 ���
        //sorting();
    }

    //�������� ������ �κ��丮 �ִ��� Ȯ���ϰ�, ������ ������ +1
    //���� �������� ������, ������ �̸��� item�� �Ѱ��ְ�, for�� 4�� ���� item�� ������ ��ȣ�� ã�� ����, �ش� �ε����� ������ inventoryâ���� �ѱ�� (return)

    //���� ���� �κ��丮
    int[,] item = new int[2,4] { //������ ���� / ������ ��ȣ / ���� / ������ ����
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
