﻿using System;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using shopEntities.Dtos;

namespace webapi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AuthController: Controller
    {
        IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
                return BadRequest(userToLogin.Message);
            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
                return BadRequest(userExists.Message);

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            if (!registerResult.Success) 
                return BadRequest(registerResult.Message);

            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }
    }
}

