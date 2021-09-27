using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    ///<summary>
    ///NPC_對話方法
    ///</summary>
    private void conversation()
    {
        ///<summary>
        ///對話內容
        ///</summary>
        string c_content = "";
    }

    ///<summary>
    ///是否開啟商店
    ///</summary>
    public bool into_store()
    {
        ///<summary>
        ///是否進入商店
        ///</summary>
        bool isInto = true;
        return isInto;
    }

    ///<summary>
    ///道具價格
    ///</summary>
    public int item_price()
    {
        ///<summary>
        ///道具價格
        ///</summary>
        int i_price = 100;
        return 0;
    }

    ///<summary>
    ///取得任務
    ///</summary>
    public void get_mission()
    {
        ///<summary>
        ///任務編號
        ///</summary>
        int m_num;
    }

    ///<summary>
    ///更新任務
    ///</summary>
    private int mission_refresh()
    {
        ///<summary>
        ///設定任務道具數量為1
        ///</summary>
        int m_item_amount = 1;
        return 0;
    }

    ///<summary>
    ///任務完成
    ///</summary>
    private bool mission_complete()
    {
        ///<summary>
        ///任務編號
        ///</summary>
        int mc_num;

        return false;
    }

}


