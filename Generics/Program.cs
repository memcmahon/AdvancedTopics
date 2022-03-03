using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics allow us to create classes or methods that take parameters of any type of object (without having to worry about boxing!)
            // Most generics that we use are pre-built in System.Collections.Generic;
            // When creating a generic, we can create constraints on the objects that can be used.

            var number = new Nullable<int>();
            Console.WriteLine("Has Value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }

        public t max<t>(t a, t b) where t : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        // Constraint types:
        // where T : ISomeInterface
        // where T : SomeSpecificClassOrItsSubClasses
        // where T : struct (it has to be a value type)
        // where T : class (it has to be a reference type)
        // where T : new() (it has to have a default constructor)
    }

    public class Nullable<T> where T : struct
    {
        // Property
        private object _value;

        // Default constructor, in case the value is not set
        public Nullable()
        {
        }

        // Constructor that takes in any value type argument
        public Nullable(T value)
        {
            _value = value;
        }

        // property
        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                // cast the value to its type (set on instantiation of the class)
                return (T)_value;

            // default will get the default value of an object Type
            return default(T);
        }
    }
} 