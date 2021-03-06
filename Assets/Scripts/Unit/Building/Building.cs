﻿using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.MonoBehaviours;

[RequireComponent(typeof(Unit))]
[RequireComponent(typeof(Inventory))]
[RequireComponent(typeof(PlayerTeam))]
public class Building : MonoBehaviour {
    public Unit MyUnit { get; private set; }
    public ProducesItem ItemsProduced { get; private set; }
    public Workers Workers { get; private set; }

    public Queue<FootUnit> UnitQueue = new Queue<FootUnit>();

    public List<Transform> BuySpots = new List<Transform>();
    public List<Transform> DeliverySpots = new List<Transform>();
    public List<Transform> WorkSpots = new List<Transform>();
    public List<Transform> EntranceSpots = new List<Transform>();
    public List<Transform> SellSpots = new List<Transform>();

    public Task baseTask;

    public void Awake() {
        this.tag = "Building";
        this.MyUnit = this.GetComponent<Unit>();
        this.Workers = this.GetComponent<Workers>();
        this.ItemsProduced = this.GetComponent<ProducesItem>();

        var spots = transform.FindChild("Spots");

        if (spots != null) {
            //Get all of the walk spots
            foreach (Transform child in spots) {
                if (child.CompareTag("Spot_Delivery"))
                    DeliverySpots.Add(child);
                else if (child.CompareTag("Spot_Work"))
                    WorkSpots.Add(child);
                else if (child.CompareTag("Spot_Entrance"))
                    EntranceSpots.Add(child);
                else if (child.CompareTag("Spot_Buy"))
                    BuySpots.Add(child);
                else if (child.CompareTag("Spot_Sell"))
                    SellSpots.Add(child);
            }
        }
    }

    public void Start() {

    }


    public void Update() {

    }
}
