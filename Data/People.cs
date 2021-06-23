using System;
using System.Collections.Generic;

namespace blazor.Data
{
    public class People
    {
        public int Count {get;set;}    
        public List<Person> Results {get;set;}
        public string Next {get;set;}
        public string Previous {get;set;}
    }
}