﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Diagnostics.Monitoring.StartupHook.Exceptions.Identification
{
    internal abstract class ExceptionIdentifierCacheCallback
    {
        public virtual void OnExceptionIdentifier(
            ulong registrationId,
            ExceptionIdentifierData data)
        {
        }

        public virtual void OnClassData(
            ulong classId,
            ClassData data)
        {
        }

        public virtual void OnFunctionData(
            ulong functionId,
            FunctionData data)
        {
        }

        public virtual void OnModuleData(
            ulong moduleId,
            ModuleData data)
        {
        }

        public virtual void OnTokenData(
            ulong moduleId,
            uint typeToken,
            TokenData data)
        {
        }
    }
}
