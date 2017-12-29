﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LiteDB
{
    /// <summary>
    /// Manages all transactions and grantees concurrency and recovery
    /// </summary>
    internal class TransactionService
    {
        private IDiskFactory _disk;
        private AesEncryption _crypto;
        private LockService _locker;
        private PageService _pager;
        private CacheService _cache;
        private Logger _log;

        internal TransactionService(IDiskFactory disk, AesEncryption crypto, PageService pager, LockService locker, CacheService cache, Logger log)
        {
            _disk = disk;
            _crypto = crypto;
            _cache = cache;
            _locker = locker;
            _pager = pager;
            _log = log;
        }

        public Transaction Read()
        {
        }

        public Transaction Write()
        {
        }

    }
}