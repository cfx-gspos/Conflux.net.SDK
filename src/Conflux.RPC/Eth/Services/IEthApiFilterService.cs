﻿using Conflux.RPC.Eth.Filters;

namespace Conflux.RPC.Eth.Services
{
    public interface IEthApiFilterService
    {
        IEthGetFilterChangesForBlockOrTransaction GetFilterChangesForBlockOrTransaction { get; }
        IEthGetFilterChangesForEthNewFilter GetFilterChangesForEthNewFilter { get; }
        IEthGetFilterLogsForBlockOrTransaction GetFilterLogsForBlockOrTransaction { get; }
        IEthGetFilterLogsForEthNewFilter GetFilterLogsForEthNewFilter { get; }
        IEthGetLogs GetLogs { get; }
        IEthNewBlockFilter NewBlockFilter { get; }
        IEthNewFilter NewFilter { get; }
        IEthNewPendingTransactionFilter NewPendingTransactionFilter { get; }
        IEthUninstallFilter UninstallFilter { get; }
    }
}