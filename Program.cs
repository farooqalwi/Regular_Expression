﻿using Regular_Expression.Classes;
using System;

namespace Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            RE_for_integer_constant.integer_RE();
            RE_for_float_constant.float_RE();
            RE_for_char_constant.char_RE();
            RE_for_string_constant.string_RE();
            RE_for_email_validation.email_RE();
            RE_for_url.url_RE();
        }
    }
}
