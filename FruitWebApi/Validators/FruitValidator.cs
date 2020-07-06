using System;
using FluentValidation;
using FruitWebApi.Models;

namespace FruitWebApi.Validators
{
    public class FruitValidator : AbstractValidator<Fruit>
    {
        public FruitValidator()
        {
            RuleFor(f => f.Name).NotEmpty();
        }
    }
}
