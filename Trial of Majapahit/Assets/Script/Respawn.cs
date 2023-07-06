using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject thePlayer;

    private void Update() {
    thePlayer.transform.position = new Vector3(491.77, 53.53, 456.46);}
}
