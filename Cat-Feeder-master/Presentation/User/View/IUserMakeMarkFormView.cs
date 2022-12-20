﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IUserMakeMarkFormView : IView
    {
        string Note { get; }

        event Action evChooseFeeder;
        event Action evMakeNoteToFeeder;
        event Action evMakeNoteByHand;
    }
}
