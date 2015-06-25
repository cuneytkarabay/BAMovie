﻿using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Business
{
    public class BusinessActor : BusinessBase<Actor>, IBusinessActor
    {
        public BusinessActor(IRepositoryBase<Actor> repository, IUnitOfWork uow)
            : base(repository, uow)
        {
        }
    }
}
