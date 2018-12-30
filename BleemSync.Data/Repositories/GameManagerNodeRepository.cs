﻿using BleemSync.Data.Abstractions;
using BleemSync.Data.Entities;
using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BleemSync.Data.Repositories
{
    public class GameManagerNodeRepository : RepositoryBase<GameManagerNode>, IGameManagerNodeRepository
    {
        public IEnumerable<GameManagerNode> All()
        {
            return dbSet.OrderBy(n => n.SortName != "" ? n.SortName : n.Name);
        }

        public void Create(GameManagerNode node)
        {
            dbSet.Add(node);
        }

        public void Update(GameManagerNode node)
        {
            storageContext.Entry(node).State = EntityState.Modified;
        }
    }
}