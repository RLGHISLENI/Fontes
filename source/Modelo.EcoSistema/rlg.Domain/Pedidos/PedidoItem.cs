using rlg.Core.Aggregates;

namespace rlg.Domain.Models
{
    internal class PedidoItem : Agregado
    {

        #region [  Construtor  ]

        #endregion

        #region [  Propriedades  ]

        public int CodigoProduto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public decimal ValorTotal { get; private set; }

        #endregion

        #region [  Validação  ]

        public bool ehValido()
        {
            return true;
        }

        #endregion

    }
}
