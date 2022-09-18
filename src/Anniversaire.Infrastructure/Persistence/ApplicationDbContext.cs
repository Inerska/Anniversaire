// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Anniversaire.Domain.AnniversaireAggregate;
using Microsoft.EntityFrameworkCore;

namespace Anniversaire.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<Birthday> Birthdays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=anniversaire.db");
    }
}