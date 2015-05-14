using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Light
    {
        private State _currentState;
        public State CurrentState
        {
            get { return _currentState; }
            set { _currentState = value; _currentState.Change(this);}
        }

    }
}
