using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappin : MonoBehaviour
{
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
        // Destruction du joint si la touche espace est appuyée afin de lâcher l'objet
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(this.gameObject.GetComponent<FixedJoint>());
        }
    }

    //Fonction qui permet de détecter si un objet est entré en collision avec le grappin pour créer un joint
    void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.GetComponent<ArticulationBody>() != null)
        {
            FixedJoint joint = this.gameObject.AddComponent<FixedJoint>();
            joint.connectedArticulationBody = Collision.articulationBody;
        }
    }
}
