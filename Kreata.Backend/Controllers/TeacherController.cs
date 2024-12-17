﻿using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private ITeacherRepo _teacherRepo;

        public TeacherController(ITeacherRepo? teacherRepo)
        {
            _teacherRepo = teacherRepo ?? throw new ArgumentNullException(nameof(teacherRepo));
        }
    }
}
