﻿using AspnetCore_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Collections.Generic;
namespace AspnetCore_WebApi.Models
{
    public interface ITarefaRepositorio
    {
        void Add(TarefaItem item);
        IEnumerable<TarefaItem> GetAll();
        TarefaItem Find(long key);
        void Remove(long key);
        void Update(TarefaItem item);
    }
}
