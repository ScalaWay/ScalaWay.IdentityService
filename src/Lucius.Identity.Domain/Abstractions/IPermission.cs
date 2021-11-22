using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Abstractions
{
    /// <summary>
    /// Used to grant/deny a permission for a role or user.
    /// </summary>
    public interface IPermission
    {
        string Name { get; }

        bool IsGranted { get; }
    }
}
