﻿using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class AddReservationSO : SOBase
    {
        protected override void ExecuteConcreteOperation(object parameter = null)
        {
            Result = broker.Add((IEntity)parameter);
        }
    }
}
