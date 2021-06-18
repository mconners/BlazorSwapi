using System;
using System.Collections.Generic;

namespace blazor.Data
{
    public class JsonWrapper
    {
        public int Count {get;set;}    
        public List<People> Results {get;set;}
        public string Next {get;set;}
        public string Previous {get;set;}
    }
}