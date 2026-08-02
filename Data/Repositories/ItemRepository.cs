// MIT License
// Copyright Eraware

using Eraware.Modules.MyModule.Data.Entities;
using Eraware.Modules.MyModule.Providers;

namespace Eraware.Modules.MyModule.Data.Repositories
{
    /// <inheritdoc cref="IItemRepository"/>
    internal class ItemRepository : Repository<Item>, IItemRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRepository"/> class.
        /// </summary>
        /// <param name="context">The underlying data-context to use.</param>
        /// <param name="dateTimeProvider">Provides information about dates and times.</param>
        public ItemRepository(ModuleDbContext context, IDateTimeProvider dateTimeProvider)
            : base(context, dateTimeProvider)
        {
        }
    }
}