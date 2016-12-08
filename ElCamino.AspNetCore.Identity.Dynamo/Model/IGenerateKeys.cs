﻿// MIT License Copyright 2014 (c) David Melendez. All rights reserved. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if net45
namespace ElCamino.AspNet.Identity.Dynamo.Model
#else
namespace ElCamino.AspNetCore.Identity.Dynamo.Model
#endif
{
    public interface IGenerateKeys
    {
        void GenerateKeys();

        string PeekRowKey();
    }
}
