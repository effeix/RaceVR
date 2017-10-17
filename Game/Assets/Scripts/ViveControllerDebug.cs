using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveControllerDebug : MonoBehaviour
{

    private SteamVR_TrackedObject trackedObj;        // referencia para o controle

    private SteamVR_Controller.Device Controller
    {   // Properties para o controle
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {                                   // recupera referência para o controle
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Exibe o valor X e Y pressionado no trackpad
        if (Controller.GetAxis() != Vector2.zero)
        {
            Debug.Log(gameObject.name + Controller.GetAxis());
        }

        // Exibe se o gatilho do controle foi pressionado
        if (Controller.GetHairTriggerDown())
        {
            Debug.Log(gameObject.name + " gatilho pressionado");
        }

        // Exibe se o gatilho do controle foi solto
        if (Controller.GetHairTriggerUp())
        {
            Debug.Log(gameObject.name + " gatilho solto");
        }

        // Exibe se os botões laterais (Grip) do controle foram pressionados
        if (Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip pressionado");
        }

        // Exibe se os botões laterais (Grip) do controle foram soltos
        if (Controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip solto");
        }

        // Exibe se o botão do touch foi pressionados
        if (Controller.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log(gameObject.name + " touch pressionado");
        }

        // Exibe se o botão do menu de aplicações foi pressionados
        if (Controller.GetPress(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            Debug.Log(gameObject.name + " menu pressionado");
        }

        // Exibe o valor X e Y pressionado no trackpad
        if (Controller.GetAxis() != Vector2.zero)
        {
            Debug.Log(gameObject.name + Controller.GetAxis());
        }

        // Exibe se o gatilho do controle foi pressionado
        if (Controller.GetHairTriggerDown())
        {
            Debug.Log(gameObject.name + " gatilho pressionado");
        }

        // Exibe se o gatilho do controle foi solto
        if (Controller.GetHairTriggerUp())
        {
            Debug.Log(gameObject.name + " gatilho solto");
        }

        // Exibe se os botões laterais (Grip) do controle foram pressionados
        if (Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip pressionado");
        }

        // Exibe se os botões laterais (Grip) do controle foram soltos
        if (Controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip solto");
        }

        // Exibe se o botão do touch foi pressionados
        if (Controller.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log(gameObject.name + " touch pressionado");
        }

        // Exibe se o botão do menu de aplicações foi pressionados
        if (Controller.GetPress(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            Debug.Log(gameObject.name + " menu pressionado");
        }



    }
}

