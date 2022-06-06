using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonAktifState : ObjectState
{
    //public NonAktifState(InteractiveObject objek) : base(objek)
    //{
    //}

    //public override void NonAktif()
    //{
    //    Debug.Log("Cek nonaktif state");
    //    _objek.SetState(new AktifState(_objek));
    //}

    
    public override void EnterState(ObjectScript objek)
    {
        Debug.Log(objek.namaObjek + " Tidak Aktif!");
    }

    public override void UpdateState(ObjectScript objek)
    {
        //Debug.Log("Aktivasi " + objek.name);
        
        //objek.SwitchState(objek.aktifState);
        if (Input.GetKeyDown(KeyCode.E) && objek.objectName == ObjectScript.ObjectName.Botol && objek.isActive == false)
        {
            objek.isActive = true;
            
            

            Debug.Log("Ganti state! " + objek.namaObjek);
            
            objek.SwitchState(objek.aktifState); // ganti state

        }
        if (Input.GetKeyDown(KeyCode.E) && objek.objectName == ObjectScript.ObjectName.Lemari && objek.isActive == false)
        {
            Debug.Log("LEmari bego");
        }
    }

   
}
