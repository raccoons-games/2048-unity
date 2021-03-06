using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Data
{
    public class ScriptableArray<TItem> : ScriptableObject, IEnumerable<TItem>
    {
        [SerializeField]
        private TItem[] _states;

        public IEnumerator<TItem> GetEnumerator()
        {
            return _states.AsEnumerable<TItem>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
