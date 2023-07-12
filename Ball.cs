using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
   public GameObject ballPrefab;
   public Transform InstatiatePos;
   
   public CameraFollow cameraFollow;
   void Start()
   {
    GameObject go = Instatiate(ballPrefab, InstatiatePos.position, Quaternion.identity);
    cameraFollow.target = go.transform;
   }
}
