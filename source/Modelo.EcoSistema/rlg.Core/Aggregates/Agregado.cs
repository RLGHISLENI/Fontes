using System;

namespace rlg.Core.Aggregates
{
    public class Agregado
    {

        #region [  Construtor  ]

        protected Agregado() { }

        #endregion

        #region [  Propriedades  ]

        public Guid IdRaiz { get; set; }
        public int Item { get; private set; }

        #endregion

    }
}
