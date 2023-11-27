using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public string ChestAwarded;
    public string PrizeAwarded;

    [Header("Chest Type")]
    public int WoodChest;
    public int BronzeChest;
    public int SilverChest;
    public int GoldChest;
    public int PlatinumChest;
    public List<string> ChestTypes;

    [Header("WoodChestDrops")]
    public int woodChestCommon;
    public int WoodChestUncommon;
    public int WoodChestRare;
    public int WoodChestEpic;
    public int WoodChestLegendary;
    public List<string> WoodChestsDrop;

    [Header("WoodChestDrops")]
    public int BronzeChestCommon;
    public int BronzeChestUncommon;
    public int BronzeChestRare;
    public int BronzeChestEpic;
    public int BronzeChestLegendary;
    public List<string> BronzeChestsDrop;

    void Start()
    {

        //chests drops
        for (int i = 0; i < WoodChest; i++)
        {
            ChestTypes.Add(new string("WoodChest"));
        }
        
        for (int i = 0; i < BronzeChest; i++)
        {
            ChestTypes.Add(new string("BronzeChest"));
        }

        for (int i = 0; i < SilverChest; i++)
        {
            ChestTypes.Add(new string("SilverChest"));
        }

        for (int i = 0; i < GoldChest; i++)
        {
            ChestTypes.Add(new string("GoldChest"));
        }

        for (int i = 0; i < PlatinumChest; i++)
        {
            ChestTypes.Add(new string("PlatinumChest"));
        }

        // Wood chests drops
        for (int i = 0; i < woodChestCommon; i++)
        {
            WoodChestsDrop.Add(new string("woodChestCommon"));
        }

        for (int i = 0; i < WoodChestUncommon; i++)
        {
            WoodChestsDrop.Add(new string("WoodChestUncommon"));
        }

        for (int i = 0; i < WoodChestRare; i++)
        {
            WoodChestsDrop.Add(new string("WoodChestRare"));
        }

        for (int i = 0; i < WoodChestEpic; i++)
        {
            WoodChestsDrop.Add(new string("WoodChestEpic"));
        }

        for (int i = 0; i < WoodChestLegendary; i++)
        {
            WoodChestsDrop.Add(new string("WoodChestLegendary"));
        }

        //Bronze chests drops
        for (int i = 0; i < BronzeChestCommon; i++)
        {
            BronzeChestsDrop.Add(new string("BronzeChestCommon"));
        }

        for (int i = 0; i < BronzeChestUncommon; i++)
        {
            BronzeChestsDrop.Add(new string("BronzeChestCommon"));
        }

        for (int i = 0; i < BronzeChestRare; i++)
        {
            BronzeChestsDrop.Add(new string("BronzeChestRare"));
        }

        for (int i = 0; i < BronzeChestEpic; i++)
        {
            BronzeChestsDrop.Add(new string("BronzeChestEpic"));
        }

        for (int i = 0; i < BronzeChestLegendary; i++)
        {
            BronzeChestsDrop.Add(new string("BronzeChestLegendary"));
        }


    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            ChestAwarded = ChestTypes[Random.Range(0, ChestTypes.Count)];

            if (ChestAwarded == "WoodChest") 
            {

                PrizeAwarded = WoodChestsDrop[Random.Range(0, WoodChestsDrop.Count)];

            }
            else if (ChestAwarded == "BronzeChest")
            {

                PrizeAwarded = WoodChestsDrop[Random.Range(0, BronzeChestsDrop.Count)];

            }
            else 
            {
                PrizeAwarded = null;
            
            }

        }

    }

}
