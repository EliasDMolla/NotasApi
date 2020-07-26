using System.Collections;
using System.Collections.Generic;

namespace NotasApi.Domain.Models 
{
    public class Response<T> where T : class
    {
        public IEnumerable<T> Entitites { get; set; } = new List<T>();
        public string MsgeError { get; set; }
        public bool ValidationError {get; set; } = false;
        public Response() {}
        public Response(List<T> _entities, string _msgeError, bool _validationError) 
        {
            Entitites = _entities;
            MsgeError = _msgeError;
            ValidationError = _validationError;
        }
        public Response(List<T> _entities) 
        {
            Entitites = _entities;
        }
        public Response(string _msgeError, bool _validationError) 
        {
            MsgeError = _msgeError;
            ValidationError = _validationError;
        }
    }
}