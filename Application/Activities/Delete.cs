using MediatR;
using Persistence;

namespace Application.Activities;

// ReSharper disable once ClassNeverInstantiated.Global
public class Delete
{
    public class Command : IRequest
    {
        public Guid Id { get; init; }
    }

    public class Handler : IRequestHandler<Command>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Id);
            if (activity != null) _context.Remove((object)activity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}