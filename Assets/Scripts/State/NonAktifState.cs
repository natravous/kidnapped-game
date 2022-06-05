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
    public override void EnterState(ExamineableObject objek)
    {
        Debug.Log(objek.name + " Tidak Aktif!");
    }

    public override void UpdateState(ExamineableObject objek)
    {
        //Debug.Log("Aktivasi " + objek.name);
        
        //objek.SwitchState(objek.aktifState);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Ganti state! " + objek.name);
            
            objek.SwitchState(objek.aktifState); // ganti state
        }
    }

   
}
