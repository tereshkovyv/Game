using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // для сохранения
public class Dialogue
{
    public string name;
    [TextArea(3,10)] //мин и макс количество строк 
    public string[] sentences;
}
