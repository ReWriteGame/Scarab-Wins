
using UnityEngine;
using UnityEngine.Events;

public class Destoyer : MonoBehaviour
{

    public UnityEvent touchBugEvent;
   private void OnTriggerEnter2D(Collider2D other)
   {
        if (other.gameObject.GetComponent<Bug>())
        {
            touchBugEvent?.Invoke();
        }
        if (other.gameObject.GetComponent<Destroyable>())
        {
            other.gameObject.GetComponent<Destroyable>().Destroy();
        }
      
   }

}
