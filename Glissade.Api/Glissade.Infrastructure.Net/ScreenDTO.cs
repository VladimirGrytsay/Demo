﻿using Glissade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glissade.Infrastructure.Net {
    public class ScreenDTO : IScreen {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Content { get; set; }
    }
}
