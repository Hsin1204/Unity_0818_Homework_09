using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    ///<summary>
    ///NPC_��ܤ�k
    ///</summary>
    ///<para name = "dialogue">NPC ��ܤ��e</para>
    private void conversation(string c_content)
    {
       
       
    }

    ///<summary>
    ///�O�_�}�Ұө�
    ///</summary>
    public bool into_store(bool isInto)
    {
        return true;
    }

    ///<summary>
    ///�D�����
    ///</summary>
    ///<para name ="i_price">�D�����/para>
    public int item_price(int i_price = 100)
    {
        
        return 0;
    }

    ///<summary>
    ///���o����
    ///</summary>
    ///<para name ="m_num">���Ƚs��/para>
    public void get_mission(int m_num)
    {
    }

    ///<summary>
    ///��s����
    ///</summary>
    ///<para name ="m_item_amount">���ȹD��ƶq/para>
    private int mission_refresh(int m_item_amount)
    {
        return 0;
    }

    ///<summary>
    ///���ȧ���
    ///</summary>
    ///<para name ="mc_num">���Ƚs��/para>
    private bool mission_complete(int mc_num)
    {
        return false;
    }

}


