﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuotingAPI.Database.Models;

namespace QuotingAPI.Database
{
    public interface IQuoteListDB
    {
        List<QuoteProducts> GetAll();
        Quote AddNew(Quote newQuote);
    }
}