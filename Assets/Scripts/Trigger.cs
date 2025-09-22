using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject gameMaster;
    public bool tripped = false;
    private void OnTriggerEnter2D()
    {
        gameMaster.GetComponent<GameManager>().Dialog(gameObject.name);
        tripped = true;
    }
}
