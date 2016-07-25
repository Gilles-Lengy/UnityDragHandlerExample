﻿using UnityEngine;
using System.Collections;

public class SpawnBlackSquares : MonoBehaviour {
    public GameObject spriteToDuplicate;

    // Use this for initialization
    void Start () {
        Vector3 currentPosition = spriteToDuplicate.transform.position;
        for (int i = 0; i < 5; i++)
        {
            GameObject.Instantiate(spriteToDuplicate, currentPosition, Quaternion.identity);
            currentPosition += new Vector3(3f, 0f, 0f);
        }
    }

	

}
