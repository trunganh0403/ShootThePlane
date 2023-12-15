using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Junk", menuName = "ScriptableObject/Junk")]
public class JunkSO : ScriptableObject
{
    public string junkName = "Junk";
    public int maxHp = 4;
}
