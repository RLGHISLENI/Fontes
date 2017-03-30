using rlg.Core.Aggregates;
using System;

namespace rlg.Domain.Models
{
    public class Pedido : RaizAgregacao
    {

        #region [  Construtor  ]

        public Pedido(Guid id)
        {
            Id = id;
        }

        #endregion

        #region [  Propriedades  ]

        public int Numero { get; private set; }
        public DateTime Data { get; private set; }
        public decimal Valor { get; private set; }

        #endregion

        #region [  Métodos  ]

        public void AdicionarItem(int codigoProduto, int quantidade, decimal valorUnitario, decimal valorTotal)
        {
            PedidoItem pedidoItem = new PedidoItem();
        }

        #endregion

        #region [  Validação  ]

        public override bool ehValido()
        {
            return true;
        }

        #endregion

    }
}