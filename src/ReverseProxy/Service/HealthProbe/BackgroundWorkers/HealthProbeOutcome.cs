﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.ReverseProxy.Service.HealthProbe
{
    // The outcome of probing the endpoint health. The class enumerate the below possible state.
    // This is also offering help on logging.
    internal enum HealthProbeOutcome
    {
        Unknown,
        Success,
        TransportFailure,
        HttpFailure,
        Timeout,
        Canceled,
    }
}
