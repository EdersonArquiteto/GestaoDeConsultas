﻿using FluentValidation.Results;

namespace TheOne.Consultas.Domain.Core
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }

        ValidationResult Validate { get; }
    }
}
