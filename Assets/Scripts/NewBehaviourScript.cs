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

    [Header("BronzeChestDrops")]
    public int BronzeChestCommon;
    public int BronzeChestUncommon;
    public int BronzeChestRare;
    public int BronzeChestEpic;
    public int BronzeChestLegendary;
    public List<string> BronzeChestsDrop;

    [Header("SilverChestDrops")]
    public int SilverChestCommon;
    public int SilverChestUncommon;
    public int SilverChestRare;
    public int SilverChestEpic;
    public int SilverChestLegendary;
    public List<string> SilverChestsDrop;

    [Header("GoldChestDrops")]
    public int GoldChestCommon;
    public int GoldChestUncommon;
    public int GoldChestRare;
    public int GoldChestEpic;
    public int GoldChestLegendary;
    public List<string> GoldChestsDrop;

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

        //Silver chests drops
        for (int i = 0; i < SilverChestCommon; i++)
        {
            SilverChestsDrop.Add(new string("SilverChestCommon"));
        }

        for (int i = 0; i < SilverChestUncommon; i++)
        {
            SilverChestsDrop.Add(new string("SilverChestCommon"));
        }

        for (int i = 0; i < SilverChestRare; i++)
        {
            SilverChestsDrop.Add(new string("SilverChestRare"));
        }

        for (int i = 0; i < SilverChestEpic; i++)
        {
            SilverChestsDrop.Add(new string("SilverChestEpic"));
        }

        for (int i = 0; i < SilverChestLegendary; i++)
        {
            SilverChestsDrop.Add(new string("SilverChestLegendary"));
        }

        //Gold chests drops
        for (int i = 0; i < GoldChestCommon; i++)
        {
            GoldChestsDrop.Add(new string("GoldChestCommon"));
        }

        for (int i = 0; i < GoldChestUncommon; i++)
        {
            GoldChestsDrop.Add(new string("GoldChestCommon"));
        }

        for (int i = 0; i < GoldChestRare; i++)
        {
            GoldChestsDrop.Add(new string("GoldChestRare"));
        }

        for (int i = 0; i < GoldChestEpic; i++)
        {
            GoldChestsDrop.Add(new string("GoldChestEpic"));
        }

        for (int i = 0; i < GoldChestLegendary; i++)
        {
            GoldChestsDrop.Add(new string("GoldChestLegendary"));
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
            else if (ChestAwarded == "SilverChest")
            {

                PrizeAwarded = WoodChestsDrop[Random.Range(0, BronzeChestsDrop.Count)];

            }
            else if (ChestAwarded == "GoldChest")
            {

                PrizeAwarded = WoodChestsDrop[Random.Range(0, BronzeChestsDrop.Count)];

            }
            else if (ChestAwarded == "PlatinumChest")
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
