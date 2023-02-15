using UnityEngine;

namespace _Source
{
    public class IgnoreColliders : MonoBehaviour
    {
        [SerializeField] private Collider[] allColliders;
        
        void Awake()
        {
            for (int i = 0; i < allColliders.Length; i++)
            {
                for (int j = 0; j < allColliders.Length; j++)
                {
                    Physics.IgnoreCollision(allColliders[i], allColliders[j], true);
                }
            }
        }
    }
}
