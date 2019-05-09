using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class changeScene : MonoBehaviour
{
 public void ChangeScene(string scenename)
 {
  Application.LoadLevel(scenename);
 }
}