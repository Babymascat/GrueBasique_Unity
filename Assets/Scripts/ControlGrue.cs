using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGrue : MonoBehaviour
{
    // ====================================================================================================
    //                     V   V    A    RRRR   III    A    BBB    L      EEEEE   SSS
    //      /              V   V   A A   R   R   I    A A   B  B   L      E      S                      /
    //     /     *         V   V  A   A  R   R   I   A   A  BBBB   L      EEE     SSS          *       /
    //    /     ***         V V   AAAAA  RRRR    I   AAAAA  B   B  L      E          S        ***     /
    //   /       *          V V   A   A  R  R    I   A   A  B   B  L      E          S         *     /
    //  /                    V    A   A  R   R  III  A   A  BBBB   LLLLL  EEEEE  SSSS               /
    // ====================================================================================================
    // Déclarations des variables
    private List<Camera> cameras;
    private int currentCameraIndex;
    public float torque = 250f;
    public float forceChariot = 500f;
    public float forceMoufle = 500f;
    public ArticulationBody pivot;
    public ArticulationBody chariot;
    public ArticulationBody moufle;

    // ==========================================================================
    //                      SSS   TTTTT    A    RRRR   TTTTT
    //      /              S        T     A A   R   R    T                    /
    //     /     *          SSS     T    A   A  R   R    T           *       /
    //    /     ***            S    T    AAAAA  RRRR     T          ***     /
    //   /       *             S    T    A   A  R  R     T           *     /
    //  /                  SSSS     T    A   A  R   R    T                /
    // ==========================================================================
    // Start est appelé avant la première frame de mise à jour
    void Start()
    {
        cameras = new List<Camera>(FindObjectsOfType<Camera>());
        currentCameraIndex = 3;
        for (int i = 0; i < cameras.Count; i++)
        {
            if (i == currentCameraIndex)
            {
                cameras[i].enabled = true;
            }
            else
            {
                cameras[i].enabled = false;
            }
        }
    }


    // =================================================================================
    //                     U   U  PPPP   DDD      A    TTTTT  EEEEE
    //      /              U   U  P   P  D  D    A A     T    E                      /
    //     /     *         U   U  P   P  D   D  A   A    T    EEE           *       /
    //    /     ***        U   U  PPPP   D   D  AAAAA    T    E            ***     /
    //   /       *         U   U  P      D  D   A   A    T    E             *     /
    //  /                   UUU   P      DDD    A   A    T    EEEEE              /
    // =================================================================================
    // Update est appelé une fois par frame
    void Update()
    {
        // Déplacement de la grue
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pivot.AddTorque(transform.up * -torque);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pivot.AddTorque(transform.up * torque);
        }

        // Commande de déplacement du chariot de la grue
        if (Input.GetKey(KeyCode.UpArrow))
        {
            chariot.AddRelativeForce(transform.right * forceChariot);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            chariot.AddRelativeForce(transform.right * -forceChariot);
        }

        // Commande de descente et montée de la moufle
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moufle.AddRelativeForce(transform.up * forceMoufle);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            moufle.AddRelativeForce(transform.up * -forceMoufle);
        }

        //Changement de caméra
        if (Input.GetKeyDown(KeyCode.V))
        {
            cameras[currentCameraIndex].enabled = false;
            currentCameraIndex++;
            if (currentCameraIndex == cameras.Count)
            {
                currentCameraIndex = 0;
            }
            cameras[currentCameraIndex].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            cameras[currentCameraIndex].enabled = false;
            currentCameraIndex--;
            if (currentCameraIndex == -1)
            {
                currentCameraIndex = cameras.Count - 1;
            }
            cameras[currentCameraIndex].enabled = true;
        }


    }
}
