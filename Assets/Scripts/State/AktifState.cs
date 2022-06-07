using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktifState : ObjectState
{
    //public AktifState(InteractiveObject objek) : base(objek)
    //{
    //}

    //public override void Aktif()
    //{
    //    Debug.Log("Cek aktif state");
    //    _objek.SetState(new NonAktifState(_objek));
    //}

    public override void EnterState(ObjectScript objek)
    {
        Debug.Log("Hello, Check Aktif! " + objek.namaObjek);
    }

    public override void UpdateState(ObjectScript objek)
    {
        Debug.Log("Sudah Aktif nih! " + objek.namaObjek);
        

        if (objek.counter >= 3)
        {
            objek.kunci.enabled = true;
            objek.obj.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.E) && objek.PlayerInRange == true && objek.objectName == ObjectScript.ObjectName.Botol && objek.isActive == true)
        {
            objek.counter++;
            Debug.Log(objek.counter);
        }
        
    }
}
