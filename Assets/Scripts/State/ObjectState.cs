using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectState
{
    // ubah 
    public virtual void EnterState(ExamineableObject objek) { }
    public virtual void UpdateState(ExamineableObject objek) { }

    //protected readonly InteractiveObject _objek;

    //public ObjectState (InteractiveObject objek)
    //{
    //    _objek = objek;
    //}

    //public virtual void Mulai(InteractiveObject objek)
    //{
    //    Debug.Log("Cek");
    //}

    //public virtual void Aktif()
    //{
    //    Debug.Log("Aktif");
    //}

    //public virtual void NonAktif()
    //{
    //    Debug.Log("Tidak Aktif");
    //}
}
