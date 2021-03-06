﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse.Models.Physics
{
    public class Panel: Device
    {
        /* public override void Init(int inputsCount, int outputsCount)
        {
            base.Init(inputsCount, outputsCount);
        } */

        public Panel()
        {

        }

        public Panel(UID id, int inputs, int outputs)
        {
            Init(id, inputs, outputs, true);
        }

        public override Device Assign(Device source)
        {
            return base.Assign(source);
        }

        public override Device Clone()
        {
            return (new Panel()).Assign(this);
        }
    }
}
