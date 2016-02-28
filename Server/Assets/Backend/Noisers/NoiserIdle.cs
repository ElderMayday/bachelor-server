using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Backend.Noisers
{
    public class NoiserIdle : Noiser
    {
        public override float Get()
        {
            return 0.0f;
        }
    }
}
