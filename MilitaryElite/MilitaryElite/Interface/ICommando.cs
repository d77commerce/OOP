﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
   public interface ICommando : ISpecialisedSoldier
    {
        public List<IMission> Missions { get; set; }
        void CompleteMission(string codeName);
    }
}
