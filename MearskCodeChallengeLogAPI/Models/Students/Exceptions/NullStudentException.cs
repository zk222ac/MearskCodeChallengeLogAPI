﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;

namespace MearskCodeChallengeLogAPI.Models.Students.Exceptions
{
    public class NullStudentException : Exception
    {
        public NullStudentException() : base(message: "The student is null.") { }
    }
}
