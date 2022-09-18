// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using System.ComponentModel.DataAnnotations;

namespace Anniversaire.Domain.AnniversaireAggregate;

public class Birthday
{
    [Key]
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;
    
    public DateTime Date { get; set; }
    
    public string? Notes { get; set; }
}