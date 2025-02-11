﻿using MediatR;
using TaskMng.Domain.Models;

namespace TaskMng.Domain.Commands
{
    public record AddUserCommand : IRequest<User>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
