using System;

namespace rlg.Core.Entities
{
    public class Entidade
    {

        #region [  Construtor  ]

        protected Entidade() { }

        #endregion

        #region [  Propriedades  ]

        public Guid Id { get; set; }

        #endregion

        #region [  Operadores  ]

        public static bool operator ==(Entidade a, Entidade b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entidade a, Entidade b)
        {
            return !(a == b);
        }

        #endregion

        #region [  Sobrescritas  ]

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entidade;

            if (ReferenceEquals(this, compareTo))
                return true;
            if (ReferenceEquals(null, compareTo))
                return false;

            return Id.Equals(compareTo.Id);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }

        #endregion

        #region [  Validações  ]

        public virtual bool ehValido()
        {
            return false;
        }

        #endregion

    }
}
