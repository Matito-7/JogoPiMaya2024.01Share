using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoldierKitten : MonoBehaviour
{
    public Transform soldier;

    private void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< Updated upstream
        collision.GetComponent<MoverMaya>().life--;
=======
        collision.GetComponent<PlayerControl>().life--;
>>>>>>> Stashed changes
    }
}
