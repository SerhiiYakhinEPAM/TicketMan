using MediatR;
using TicketMan.Application.Common.Interfaces;
using TicketMan.Domain.Entities;

public class CreateUserCommand : IRequest<int>
{
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
    public int UserRoleId { get; set; }
}

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly ITmDbContext _context;

    public CreateUserCommandHandler(ITmDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            PasswordHash = request.PasswordHash,
            Email = request.Email,
            FullName = request.FullName,
            UserRoleId = request.UserRoleId
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync(cancellationToken);

        return user.Id;
    }
}