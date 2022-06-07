using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : InteractiveObject
{
    public string namaObjek;

    //private static ObjectScript _instance;
    //public static ObjectScript Instance
    //{
    //    get
    //    {
    //        if (_instance == null)
    //        {
    //            _instance = FindObjectOfType<ObjectScript>();
    //        }
    //        return _instance;
    //    }
    //}

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

    //

    public KeyObject kunci;
    public ExamineableObject obj;

    

    protected ObjectState _currentState; // reference to the active state
    //isntantiate a new state below
    public AktifState aktifState = new AktifState();
    public NonAktifState nonAktifState = new NonAktifState();

    public void SetState(ObjectState state)
    {
        _currentState = state;
        _currentState.EnterState(this);
    }
    public void SwitchState(ObjectState state)
    {
        _currentState = state;
        //if(name == ObjectName.Lemari)//
        state.EnterState(this);
    }

    //private void Awake()
    //{
    //    kunci = GameObject.FindObjectOfType<KeyObject>();
    //}

    private void Start()
    {
        

        NetralColor();
        SetState(nonAktifState); // set state


        kunci.enabled = false;
        obj.enabled = false;
    }
    private void Update()
    {
        _currentState.UpdateState(this);
    }

    
}
