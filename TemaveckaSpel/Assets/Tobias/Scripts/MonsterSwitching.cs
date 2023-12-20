using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSwitching : MonoBehaviour
{
    public int activeMonster = 1;
    public GameObject Khughah;
    public GameObject Baanaassih;
    public GameObject GumpFarmer;
    public GameObject Brobdingnagian;
    public GameObject Keeni;
    public GameObject Sigge;

    public void Start()
    {
        if (activeMonster == 1)
        {
            Khughah.SetActive(true);
            Baanaassih.SetActive(false);
            GumpFarmer.SetActive(false);
            Brobdingnagian.SetActive(false);
            Keeni.SetActive(false);
            Sigge.SetActive(false);
        }

        if (activeMonster == 2)
        {
            Khughah.SetActive(false);
            Baanaassih.SetActive(true);
            GumpFarmer.SetActive(false);
            Brobdingnagian.SetActive(false);
            Keeni.SetActive(false);
            Sigge.SetActive(false);
        }

        if (activeMonster == 3)
        {
            Khughah.SetActive(false);
            Baanaassih.SetActive(false);
            GumpFarmer.SetActive(true);
            Brobdingnagian.SetActive(false);
            Keeni.SetActive(false);
            Sigge.SetActive(false);
        }

        if (activeMonster == 4)
        {
            Khughah.SetActive(false);
            Baanaassih.SetActive(false);
            GumpFarmer.SetActive(false);
            Brobdingnagian.SetActive(true);
            Keeni.SetActive(false);
            Sigge.SetActive(false);
        }

        if (activeMonster == 5)
        {
            Khughah.SetActive(false);
            Baanaassih.SetActive(false);
            GumpFarmer.SetActive(false);
            Brobdingnagian.SetActive(false);
            Keeni.SetActive(true);
            Sigge.SetActive(false);
        }

        if (activeMonster == 6)
        {
            Khughah.SetActive(false);
            Baanaassih.SetActive(false);
            GumpFarmer.SetActive(false);
            Brobdingnagian.SetActive(false);
            Keeni.SetActive(false);
            Sigge.SetActive(true);
        }
    }
}