using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public TMP_InputField InputFieldLeft;
   public TMP_InputField InputFieldRight;
   
   public void Say(string textToSay)
   {
      Debug.Log(message:"Hello, World");
   }

   public void AddInts()
   {
      int leftNumber = int.Parse(InputFieldLeft.text);
      int rightNumber = int.Parse(InputFieldRight.text);
      

      Debug.Log(message:leftNumber + rightNumber);
   }
}

