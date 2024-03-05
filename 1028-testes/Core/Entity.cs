using System;
using System.Diagnostics.CodeAnalysis;
using FluentValidation.Results;

namespace _1028_testes.Core
{    
    public abstract class Entity
    {
        [ExcludeFromCodeCoverage]
        public Guid Id { get; protected set; }
        public ValidationResult ValidationResult { get; protected set; }       

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
        
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }
    }
}
