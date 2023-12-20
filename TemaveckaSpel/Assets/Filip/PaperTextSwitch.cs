using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PaperTextSwitch : MonoBehaviour
{
    public int activeMonster = 1;
    public GameObject Khughah;
    public GameObject Baanaassih;
    public GameObject GumpFarmer;
    public GameObject Brobdingnagian;
    public GameObject Keeni;
    public GameObject Sigge;
    public GameObject SiggeJR;
    public TextMeshProUGUI textMeshProUGUI;

    public string Monster1Desc = "Khughah:\r\nSomething is terribly wrong with this creature. It seems to be in constant pain, possibly because of some kind of birth defect. As a result of this pain it is always screaming unless it is sleeping. It's very slow and has not attacked anyone yet.\r\n";
    public string Monster2Desc = "Baanaassih: \r\nThis creature doesn't eat or sleep. We are unsure of what gives it energy. \r\nWhen placed in the same room as another creature it will attempt to kill it. \r\nAgain, we are unsure of the reason for this.";
    public string Monster3Desc = "Gumpfarmer: \r\nGumpfarmer is imfamous amung the staff at RIB. It is always bothering them, presumably because it is bored. It seams to calm doen when given food. \r\nIt gets violent when you don't do what you want it to. It is quite strong, there are even reports of it breaking staffs' bones.";
    public string Monster4Desc = "Brobdingnnagian:\r\nThis creature thinks very highly of itself. It seems to think that it is the leader of the monsters here. Because of that it is very terratorial and attacks if you get too close.\r\nIt is too powerful for you to fight on your own so it's best to keep your distance.";
    public string Monster5Desc = "Keeni:\r\nKeeni can usually be seen crying in the corner of it's room. It's difficult to get it's attention, it doesn't appear to be interested in anything. It has not attacked anyone, but you should still not approach it. The flower on it's head is poisonous and has reportedly killed a staff member.";


    public GameObject PaperWhere;

    public void Update()
    {
        
            if (activeMonster == 1)
            {
                     Khughah.SetActive(true);
                     Baanaassih.SetActive(false);
                     GumpFarmer.SetActive(false);
                     Brobdingnagian.SetActive(false);
                     Keeni.SetActive(false);
                     Sigge.SetActive(false);
                     if (PaperWhere.transform.position == new Vector3(0, 0, 0))
                     {                   
                        textMeshProUGUI.text = Monster1Desc;
                     }
                     else
                     {
                        textMeshProUGUI.text = null;
                     }
            }

            if (activeMonster == 2)
            {
                     Khughah.SetActive(false);
                     Baanaassih.SetActive(true);
                     GumpFarmer.SetActive(false);
                     Brobdingnagian.SetActive(false);
                     Keeni.SetActive(false);
                     Sigge.SetActive(false);
                     if (PaperWhere.transform.position == new Vector3(0, 0, 0))
                     {                    
                       textMeshProUGUI.text = Monster2Desc;
                     }
            else
            {
                textMeshProUGUI.text = null;
            }
        }        

            if (activeMonster == 3)
            {

                     Khughah.SetActive(false);
                     Baanaassih.SetActive(false);
                     GumpFarmer.SetActive(true);
                     Brobdingnagian.SetActive(false);
                     Keeni.SetActive(false);
                     Sigge.SetActive(false);
                      if (PaperWhere.transform.position == new Vector3(0, 0, 0))
                      {                      
                       textMeshProUGUI.text = Monster3Desc;
                }
                else
                {
                    textMeshProUGUI.text = null;
                }
            }

            if (activeMonster == 4)
            {

                     Khughah.SetActive(false);
                     Baanaassih.SetActive(false);
                     GumpFarmer.SetActive(false);
                     Brobdingnagian.SetActive(true);
                     Keeni.SetActive(false);
                     Sigge.SetActive(false);
                      if (PaperWhere.transform.position == new Vector3(0, 0, 0))
                      {                     
                      textMeshProUGUI.text = Monster4Desc;
                      }
            else
            {
                textMeshProUGUI.text = null;
            }
            }

            if (activeMonster == 5)
            {
                     Khughah.SetActive(false);
                     Baanaassih.SetActive(false);
                     GumpFarmer.SetActive(false);
                     Brobdingnagian.SetActive(false);
                     Keeni.SetActive(true);
                     Sigge.SetActive(false);
                       if (PaperWhere.transform.position == new Vector3(0, 0, 0))
                       {                         
                           textMeshProUGUI.text = Monster5Desc;
                       }
            else
            {
                textMeshProUGUI.text = null;
            }
            }          

            if (activeMonster == 6)
            {
                     Khughah.SetActive(false);
                     Baanaassih.SetActive(false);
                     GumpFarmer.SetActive(false);
                     Brobdingnagian.SetActive(false);
                     Keeni.SetActive(false);
                     Sigge.SetActive(true);
                     if(PaperWhere.transform.position == new Vector3(0, 0, 0)) 
                        {
                        SiggeJR.SetActive(true);   
                        }
                     else 
                        {
                        SiggeJR.SetActive(false);
                        }
                     textMeshProUGUI.text = null;
            }
    }
}
