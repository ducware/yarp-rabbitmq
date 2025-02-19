﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MSE.User.Api.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly IMediator _mediator;
        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
