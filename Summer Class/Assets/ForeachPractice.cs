using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
public class ConversationScript : MonoBehaviour
{
   public int charisma = 5;

	void Greet()
	{
		switch (charisma)
		{
		case 5:
			print ("Did it hurt when you fell from Heaven?");
			break;
		case 4:
			print ("What's cookin', good-lookin'?");
			break;
		case 3:
			print ("Yo.");
			break;
		case 2:
			print ("I like turtles.");
			break;
		case 1:
			print ("HODOR!");
			break;
		default:
			print ("Incorrect charisma level.");
			break;
			}
		}
	}
}