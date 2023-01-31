using Blog.Net.Entities.Concrete;
using FluentValidation;

namespace Blog.Net.Services.Validation.FluentValidation
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(p => p.Rate).LessThanOrEqualTo(5);
            RuleFor(p => p.Rate).GreaterThanOrEqualTo(0);
            RuleFor(p => p.Text).NotEmpty();
        }
    }
}
