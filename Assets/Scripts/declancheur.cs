using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class declancheur : MonoBehaviour
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
    int stocks = 0;


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
        //Affichage du nombre d'éléments dans le stock
        Debug.Log("Stocks : " + stocks);
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

    }

    //Fonction qui permet de détecter si un objet est entré dans le trigger => zone de stockage
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Elément ajouté");
        stocks++;
        Debug.Log("Stocks : " + stocks);

    }

    //Fonction qui permet de détecter si un objet est sorti du trigger => zone de stockage
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Elément enlevé");
        stocks--;
        Debug.Log("Stocks : " + stocks);
    }
}
