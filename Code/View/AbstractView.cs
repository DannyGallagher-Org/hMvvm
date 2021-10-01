using RSG;
using UnityEngine;

namespace View
{
    public abstract class AbstractView : MonoBehaviour
    {
        protected abstract IPromise AnimateOn();
        protected abstract IPromise AnimateOff();
    }
}