// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;

namespace MearskCodeChallengeLogAPI.Models.Students.Exceptions
{
    public class LockedStudentException : Exception
    {
        public LockedStudentException(Exception innerException)
            : base(message: "Locked student record exception, please try again later.", innerException) { }
    }
}
