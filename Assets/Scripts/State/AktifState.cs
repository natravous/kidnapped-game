using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktifState : ObjectState
{
    public override void EnterState(ObjectScript objek)
    {
        Debug.Log("Hello, Check Aktif! " + objek.namaObjek);
    }

    public override void UpdateState(ObjectScript objek)
    {
        Debug.Log("Sudah Aktif nih! " + objek.namaObjek);
        

        //if (objek.counter >= 10)
        //{
        //    objek.kunci.enabled = true;
        //    objek.obj.enabled = true;
        //}
        
        // Objek Botol
        if (Input.GetKeyDown(KeyCode.E) && objek.PlayerInRange == true && objek.objectName == ObjectScript.ObjectName.Botol && objek.isActive == true)
        {
            objek.counter++;
            Debug.Log(objek.counter);
            if (objek.counter >= 4)
            {
                objek.kunci.enabled = true;
                objek.obj.enabled = true;
            }
        }

        // Objek Note
        if (Input.GetKeyDown(KeyCode.E) && objek.PlayerInRange == true && objek.objectName == ObjectScript.ObjectName.Note && objek.isActive == true)
        {
            objek.counter++;
            Debug.Log(objek.counter);
            if (objek.counter >= 4)
            {
                objek.kunci.enabled = true;
                objek.obj.enabled = true;
            }
        }
    }

    //public AktifState(InteractiveObject objek) : base(objek)
    //{
    //}

    //public override void Aktif()
    //{
    //    Debug.Log("Cek aktif state");
    //    _objek.SetState(new NonAktifState(_objek));
    //}

}
