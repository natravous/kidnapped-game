using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : ExamineableObject
{


    public string namaObjek;

    public bool isActive = false;
    public enum ObjectName
    {
        Lemari,
        Patung,
        Botol,
        Kunci,
        Pintu
    }

    public ObjectName objectName;
}
