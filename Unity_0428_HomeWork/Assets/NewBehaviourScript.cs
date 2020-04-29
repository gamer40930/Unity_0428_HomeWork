using UnityEngine;
using UnityEngine.UI;




public class NewBehaviourScript : MonoBehaviour
{

    [Header ("蝙蝠數值")]
    public int  BatHp = 300;
    public int  BatAtk = 15;
    public int  BatHeal = 5;

    [Header ("史萊姆數值")]
    public int  SlimeHp = 150;
    public int  SlimeAtk = 10;
    public int  SlimeHeal = 10;

    [Header("顯示資訊")]
    public Text result;
    public Text BHP;
    public Text SHP;

    [Header("扣加血資訊")]
    public Text InfoBox;
    public Text InfoBox2;


    

    public void Update()
    {

        //更新當前血量
        BHP.text = " 蝙蝠血量 :" + BatHp;
        SHP.text = " 史萊姆血量 :" + SlimeHp ;

         
    }

    #region 
    /// <summary>
    /// 蝙蝠攻擊
    /// </summary> 
    public void BAtk()
    {
        SlimeHp = SlimeHp - BatAtk;
        result.text = "<color=#00FF01FF>史萊姆</color> - 受到傷害 : " + BatAtk + "\n" + "<color=#00FF01FF>史萊姆</color> - 血量剩下 : " + SlimeHp;
        InfoBox2.text = "-" + BatAtk ;
        InfoBox.text = "";
     }

        /// <summary>
    /// 蝙蝠補血
    /// </summary>
    public void BHeal()
    {
        BatHp = BatHeal + BatHp;
        result.text = "<color=#000000>蝙蝠</color> - 受到治癒 : " + BatHeal   + "\n" + "<color=#000000>蝙蝠</color> - 血量剩下 : " + BatHp;
        InfoBox.text = "+" + BatHeal ;
        InfoBox2.text = "";
        
    }
    
    /// <summary>
    /// 史萊姆攻擊
    /// </summary>
    public void SAtk()
    {
        BatHp = BatHp - SlimeAtk;
        result.text = "<color=#000000>蝙蝠</color> - 受到傷害 : " + SlimeAtk  + "\n" + "<color=#000000>蝙蝠</color> - 血量剩下 : " + BatHp ;
        InfoBox.text = "-" + SlimeAtk;
        InfoBox2.text = "";
    }

    /// <summary>
    /// 史萊姆補血
    /// </summary>
    public void SHeal()
    {
        SlimeHp = SlimeHp + SlimeHeal;
        result.text = "<color=#00FF01FF>史萊姆</color> - 受到治癒 : " + SlimeHeal  + "\n" + "<color=#00FF01FF>史萊姆</color> - 血量剩下 : " + SlimeHp;
        InfoBox2.text = "+" + SlimeHeal ;
        InfoBox.text = "";
        
    }
    #endregion 





}
