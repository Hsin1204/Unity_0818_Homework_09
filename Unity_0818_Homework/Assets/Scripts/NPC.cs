using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    ///<summary>
    ///NPC_對話方法
    ///</summary>
    ///<para name = "dialogue">NPC 對話內容</para>
    private void conversation(string c_content)
    {
       
       
    }

    ///<summary>
    ///是否開啟商店
    ///</summary>
    public bool into_store(bool isInto)
    {
        return true;
    }

    ///<summary>
    ///道具價格
    ///</summary>
    ///<para name ="i_price">道具價格/para>
    public int item_price(int i_price = 100)
    {
        
        return 0;
    }

    ///<summary>
    ///取得任務
    ///</summary>
    ///<para name ="m_num">任務編號/para>
    public void get_mission(int m_num)
    {
    }

    ///<summary>
    ///更新任務
    ///</summary>
    ///<para name ="m_item_amount">任務道具數量/para>
    private int mission_refresh(int m_item_amount)
    {
        return 0;
    }

    ///<summary>
    ///任務完成
    ///</summary>
    ///<para name ="mc_num">任務編號/para>
    private bool mission_complete(int mc_num)
    {
        return false;
    }

}


