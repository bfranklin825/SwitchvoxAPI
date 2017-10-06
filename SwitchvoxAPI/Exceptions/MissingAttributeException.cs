﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SwitchvoxAPI.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a type property is missing a required attribute.
    /// </summary>
    [Serializable]
    public class MissingAttributeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingAttributeException"/> class.
        /// </summary>
        public MissingAttributeException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingAttributeException"/> class with the attribute that was missing, the property it was missing from, and the type the property belonged to.
        /// </summary>
        /// <param name="type">The type whose property was missing an attribute.</param>
        /// <param name="property">The property that was missing an attribute.</param>
        /// <param name="attribute">The attribute that was missing.</param>
        public MissingAttributeException(Type type, string property, Type attribute) : base(GetMessage(type, property, attribute))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingAttributeException"/> class with the attribute that was missing, the property it was missing from, and the type the property belonged to and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="type">The type whose property was missing an attribute.</param>
        /// <param name="property">The property that was missing an attribute.</param>
        /// <param name="attribute">The attribute that was missing.</param>
        /// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner"/> parameter is not null, the current exception is raised in a catch block that handles the inner exception.</param>
        public MissingAttributeException(Type type, string property, Type attribute, Exception inner) : base(GetMessage(type, property, attribute), inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingAttributeException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected MissingAttributeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        private static string GetMessage(Type type, string property, Type attribute)
        {
            return $"Property '{property}' of type '{type}' is missing a {attribute}";
        }
    }
}
