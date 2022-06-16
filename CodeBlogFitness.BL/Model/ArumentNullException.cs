using System;
using System.Runtime.Serialization;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    internal class ArumentNullException : Exception
    {
        private string v;
        private object value;

        public ArumentNullException()
        {
        }

        public ArumentNullException(string message) : base(message)
        {
        }

        public ArumentNullException(string v, object value)
        {
            this.v = v;
            this.value = value;
        }

        public ArumentNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArumentNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}