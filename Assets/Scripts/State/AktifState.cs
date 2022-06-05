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

    public override void EnterState(ExamineableObject objek)
    {
        //Debug.Log("Hello, Check Aktif! " + objek.name);
    }

    public override void UpdateState(ExamineableObject objek)
    {
        //Debug.Log("Sudah Aktif nih! " + objek.name);
    }
}
