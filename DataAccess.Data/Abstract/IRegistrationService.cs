﻿using DataAccess.Model.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data.Abstract
{
    public interface IRegistrationService
    {
        public string RegisterOrUpdate(RegisterTeam registerTeam);
    }
}
