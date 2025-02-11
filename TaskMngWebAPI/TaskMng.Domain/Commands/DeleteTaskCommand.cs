﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMng.Domain.Commands
{
    public record DeleteTaskCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
